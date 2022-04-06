#include "NN.h"

NN::Input::Input(float w) {
	value = w;

}

NN::Input::Input()
{
	value = 0;
}

NN::Neuron::Neuron(std::array <double, 7> weights)
{
	activated = false;
	inputWeights = weights;
}


void NN::init() {
	
	isNotBusy = new Neuron ({0, 0.3, 0.1, 0.4, 0.4, 0.8, 0.2});
	isFriend = new Neuron ({0, 0.8, 0.8, 0.4, 0.8, 0.5, 0.6});

	hiddenLayor[0] = isNotBusy;
	hiddenLayor[1] = isFriend;
}

void NN::start(Me* me,  float known, float rel, const char* sex, float chatF, float chatL) {
	std::array <Input*, 7> inputs = {
		chatLevel = new Input(chatL),
		NPCKnown = new Input(known),
		npcLikeness = new Input(rel / 100),
		npcSex = new Input(compareSex(sex, me->sex.c_str())),
		chatFriendliness = new Input(chatF),
		myState = new Input(calculateState(me->state)),
		myHappiness = new Input(me->friendliness) 
	};
	feedFoward(inputs);
}

float NN::compareSex(const char* NPCsex, const char* MEsex) {
	if (NPCsex == MEsex) {
		return 1.0f;
	}
	else {
		return 0.5f;
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

void NN::feedFoward( std::array <Input*, 7> inputLayor)
{
	std::array<Neuron*, 2> outputs;
	int chatLevel = inputLayor[0]->value;
	std::cout << "Input layer 0" <<  inputLayor[0]->value << std::endl;

	std::cout << hiddenLayor.size() << std::endl;

	for (int i = 0; i < hiddenLayor.size(); i++) {
		for (int j = 0; j < inputLayor.size(); j++ ) {
			double f = hiddenLayor[i]->inputWeights[j] * inputLayor[j]->value;
			std::cout << "hiddenLayor: " << i << std::endl << "weight: " << hiddenLayor[i]->inputWeights[j] << std::endl <<
				"Input: " << inputLayor[j]->value << std::endl;

			std::cout << f << std::endl;
		}
	}

}

double NN::testFunction(double d) {
	
	return tanh(d);
}


