#pragma once
#include "Main.h"
#define MyFunctions _declspec(dllexport)

Me* Main::me;
NPC* Main::npc;
BST Main::Tree;
NN Main::nn;

BSTR toStr(std::string str) {
	return SysAllocString(_bstr_t(str.c_str()).Detach());
}

extern "C" {

	MyFunctions void init(int id, const char* name, const char* job, int start, int finish, int days[7]) {
		Main::me = new Me(id, name, job, start, finish, days);
		Main::npc = new NPC(id);
		Main::npc->addName(name);
		Main::Tree.insert(Main::npc);

		Main::me->print();
	}

	
	MyFunctions BSTR getInteractedWith(int id, int messageFriendliness, int messageLevel, int worldTime) {
		Main::npc = Main::Tree.search(id);
		std::string sex;
		if (Main::npc == NULL) {
			Main::nn.start(0, 50, sex.c_str(), messageFriendliness, messageLevel, worldTime);
		}
		else {
			Main::nn.start(1, Main::npc->relationship, Main::npc->sex.c_str(), messageFriendliness, messageLevel, worldTime);
		}

		

		return 0;
	}

	MyFunctions BSTR beginInteraction(int id) {

		if (Main::npc->idNum != id) {
			Main::npc = Main::Tree.search(id);
			if (Main::npc == NULL) {
				NPC* newNPC = new NPC(id);
				Main::Tree.insert(newNPC);
				Main::npc = newNPC;
				return toStr("What is your name?");
			}
			else {
				std::string n = Main::npc->name;
				return toStr("Hi " + n);
			}
		}
		else {
			return toStr("Hows it going " + Main::npc->name);
		}
	}
	

}