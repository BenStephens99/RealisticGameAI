#include "NPC.h"


NPC::NPC(int id) {
	idNum = id;
	name = "No Name";
	relationship = 50;

	left = NULL;
	right = NULL;
}

void NPC::addName(const char* n)
{
	name = n;
}
