#pragma once
#include "Main.h"
#define MyFunctions _declspec(dllexport)

NPC* Main::npc;
WorkingTree Main::workingTree;
IdleTree Main::idleTree;
const char* Main::state;


BSTR toStr(std::string str) {
	return SysAllocString(_bstr_t(str.c_str()).Detach());
}

extern "C" {

	MyFunctions BSTR test(NPC* npcNode, const char* state) {
		Main::npc = npcNode;
		Main::state = state;
		return toStr("This Worked");
	}

	MyFunctions BSTR aprroached(NPC* npcNode, const char* state) {
		Main::state = state;
		Main::npc = npcNode;

		std::string Working = "Working";

		if (Main::state == Working) {
			return toStr(Main::workingTree.start());
		}
		else {
			return toStr(Main::idleTree.start());
		}
	}







}

