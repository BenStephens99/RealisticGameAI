#include "DecisonNodes.h"
#include "DecisionNode.h"
#include "Main.h"

DecisionNode* DecisonNodes::Known_Unknown::Evaluate()
{
	if (Main::npc != NULL) {
		return leftNode;
	}
	else {
		return rightNode;
	}
}

DecisionNode* DecisonNodes::Like_Dislike::Evaluate()
{
	std::cout << Main::npc->relationship << std::endl;

	if (Main::npc->relationship >= 70) {
		return leftNode;
	}
	else if (Main::npc->relationship <= 30) {
		return rightNode;
	}
	else {
		return NULL;
	}
}

DecisionNode* DecisonNodes::Named_UnNamed::Evaluate()
{	
	std::string Unknown = "Unknown";
	
	if (Main::npc->name != Unknown) {
		return leftNode;
	}
	else {
		return rightNode;
	}
}

DecisionNode* DecisonNodes::LikedPlus_Liked::Evaluate()
{
	if (Main::npc->relationship >= 90) {
		return leftNode;
	}
	else {
		return rightNode;
	}
}


