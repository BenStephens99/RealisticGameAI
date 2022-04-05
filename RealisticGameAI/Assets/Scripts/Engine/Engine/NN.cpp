#include "NN.h"

NN::Input::Input(float w) {
	weight = w;

}

NN::Input::Input()
{
	weight = 0;
}


void NN::start(int known, int rel, const char* sex, int chatF, int chatL, int time) {
	std::vector<Input*> inputs = {
			NPCKnown = new Input(known),

			npcLikeness = new Input(rel / 100),

			npcSex = new Input(known),

			chatFriendliness = new Input(chatF),

			chatLevel = new Input(chatL),

			//myState = new Input(calculateState(me->state)),

			//myHappiness = new Input(me->friendliness),

			hasTime = new Input(time),
	};

}

int NN::compareSex(std::string sex) {
	if (sex == "Male") {
		return 1;
	}
	else {
		return 0;
	}
}

int NN::calculateState(std::string state) {
	if (state == "Idle") {
		return 1;
	}
	else {
		return 0;
	}
}

void NN::feedFoward(Input* inputs[])
{
}
