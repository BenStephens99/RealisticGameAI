#include "DecisonNodes.h"
#include "DecisionNode.h"
#include "Main.h"

DecisionNode* DecisonNodes::Working_Idle::Evaluate()
{
	
	if (Main::me->currentState == "Working") {
		std::cout << leftNode << std::endl;
		return leftNode;
	}
	else {
		return rightNode;
	}
}

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
	
	if (Main::npc->relationship > 70) {
		return leftNode;
	}
	else if (Main::npc->relationship < 20) {
		return rightNode;
	}
	else {
		return NULL;
	}
}
