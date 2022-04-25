#include "InteractTree.h"
#include "Main.h"

std::string InteractTree::IdleOrBusy::Evaluate()
{
	if (Main::me->currentState == "Working") {
		return "Left";
	}
	else {
		return "Right";
	}
}
