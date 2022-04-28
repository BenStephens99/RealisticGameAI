#pragma once
#include "Main.h"
#define MyFunctions _declspec(dllexport)

Me* Main::me;
NPC* Main::npc;
BST Main::BST;
TreeApproached Main::approached;

BSTR toStr(std::string str) {
	return SysAllocString(_bstr_t(str.c_str()).Detach());
}

extern "C" {

	MyFunctions BSTR init(const char* n, int i) {
		Main::me = new Me(n, i);
		return toStr("Name: " + Main::me->name);
	}

	MyFunctions BSTR aproached(int npc) {
		Main::npc = Main::BST.search(npc);
		return toStr(Main::approached.start());
	}

	MyFunctions void updateState(const char* s) {
		Main::me->currentState = s;
	}

	MyFunctions void addNewNPC(int id, int rel) {
		NPC* newNPC = new NPC(id);
		newNPC->relationship = rel;
		Main::BST.insert(newNPC);
	}



}

