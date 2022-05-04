#pragma once
#include "Main.h"
#define MyFunctions _declspec(dllexport)

NPC* Main::npc;
WorkingTree Main::workingTree;
std::string Main::state;

BSTR toStr(std::string str) {
	return SysAllocString(_bstr_t(str.c_str()).Detach());
}

extern "C" {


	MyFunctions BSTR test(int npcNode) {
	
		return toStr("Hello WOrld");
	}

	MyFunctions BSTR aprroached(NPC* npc, const char* state) {
		Main::npc = npc;
		Main::state = state;

		if (Main::state == "Working") {
			return toStr(Main::workingTree.start());
		}
		else {
			return toStr("Boo");
		}
	}







}

