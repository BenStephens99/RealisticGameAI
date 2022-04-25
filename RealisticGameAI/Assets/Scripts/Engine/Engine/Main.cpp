#pragma once
#include "Main.h"
#define MyFunctions _declspec(dllexport)

Me* Main::me;
NPC* Main::npc;
BST Main::BST;
walkPastTree Main::WalkPastTree;
workingTree Main::WorkingTree;

BSTR toStr(std::string str) {
	return SysAllocString(_bstr_t(str.c_str()).Detach());
}

extern "C" {

	MyFunctions BSTR init(const char* n, int i) {
		Main::me = new Me(n, i);
		return toStr("Name: " + Main::me->name);
	}

	MyFunctions void updateState(const char* s) {
		Main::me->currentState = s;
	}

	MyFunctions void addNewNPC(int id, int rel) {
		NPC* newNPC = new NPC(id);
		newNPC->relationship = rel;
		Main::BST.insert(newNPC);
	}

	MyFunctions BSTR walkPast(int npc) { 
		return toStr(Main::WalkPastTree.start(npc));
	}

	MyFunctions BSTR working(int npc){
		return toStr(Main::WorkingTree.start(npc));
	}

}

