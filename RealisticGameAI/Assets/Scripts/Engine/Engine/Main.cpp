#include "Main.h"

#define MyFunctions _declspec(dllexport)

BST Tree;
NPC* npc;

struct details {
public:
	int idNum=0;
	std::string job;
	std::string name;
}me;


extern "C" {


	BSTR toStr(std::string str) {
		return SysAllocString(_bstr_t(str.c_str()).Detach());
	}

	MyFunctions void init(int id, const char* name, const char* job) {
		npc = new NPC(id);
		npc->addName(name);
		Tree.insert(npc);

		me.idNum = id;
		me.job = job;
		me.name = name;
	}

	MyFunctions BSTR getInteractedWith(int id) {
		
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


}