#pragma once
#include <string>
#include <iostream>
#include <vector>
#include <array>
#include <math.h>
#include "Me.h"
#include "Interact.h"

class NN
{
public:
	class Input
	{
	public:
		double value;

		Input(float);
		Input();
	};

	 Input* chatLevel;
	 Input* NPCKnown;
	 Input* npcLikeness;
	 Input* npcSex;
	 Input* chatFriendliness; 
	 Input* myState;
	 Input* myHappiness;

	 class Neuron {
	 public:
		 bool activated;
		 std::array <double, 7> inputWeights;

		 Neuron(std::array <double, 7>);
	};

	 Neuron* isNotBusy;
	 Neuron* isFriend;

	 std::array <Neuron*, 2> hiddenLayor;

	void init();

	void start(Me* me, float known, float rel, const char* sex, float chatF, float chatL);

	float compareSex(const char*, const char*);

	int calculateState(std::string);

	void feedFoward(std::array <Input*, 7>);

	double testFunction(double);
	
	std::string getOutput(std::array <Neuron*, 2> HL);
};

