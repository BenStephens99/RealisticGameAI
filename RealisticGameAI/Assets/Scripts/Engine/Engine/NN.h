#pragma once
#include <string>
#include <iostream>
#include <vector>

class NN
{
public:
	class Input
	{
	public:
		float weight;

		Input(float);
		Input();
	};

	Input* NPCKnown;
	Input* npcLikeness;
	Input* npcSex;
	Input* chatFriendliness;
	Input* chatLevel;
	Input* myState;
	Input* myHappiness;
	Input* hasTime;

	class Neuron {
	public:
		bool activated;
		std::vector<Input*> inputs;

	};

	Neuron* isBusy;
	Neuron* isFriend;
	Neuron* chatNeuron;

	Input* inputLayor[8];
	Neuron* hiddenLayor[4];

	void start(int known, int rel, const char* sex, int chatF, int chatL, int time);

	int compareSex(std::string sex);

	int calculateState(std::string);

	void feedFoward(Input* inputs[]);

	
};

