#include "Main.h"

#define MyFunctions _declspec(dllexport)

BST Tree;
NPC* npc;
int idNum;

extern "C" {


	BSTR toStr(std::string str) {
		return SysAllocString(_bstr_t(str.c_str()).Detach());
	}

	MyFunctions void init(int id, const char* name) {
		npc = new NPC(id);
		npc->addName(name);
		idNum = id;
		Tree.insert(npc);
	}

	MyFunctions BSTR talk(int a)
	{
		std::string t = "hello";

		//NPC* newNPC = new NPC(5);

		//Tree.insert(newNPC);

		return toStr(t);
	}


	MyFunctions BSTR beginInteraction(int id) {

			if (npc->idNum != id) {
				npc = Tree.search(id);
				if (npc == NULL) {
					NPC* newNPC = new NPC(id);
					Tree.insert(newNPC);
					npc = newNPC;
					return toStr("What is your name?");
				}
				else {
					std::string n = npc->name;
					return toStr("Hi " + n);
				}
			}
			else {
				return toStr("Hows it going " + npc->name);
			}
	}

	MyFunctions BSTR firstMeet(const char* name) {
		npc->addName(name);

		return toStr("Nice to meet you " + npc->name);
	}


}