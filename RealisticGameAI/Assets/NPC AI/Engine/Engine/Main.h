#pragma once
#define MyFunctions _declspec(dllexport)

#include <comdef.h>
#include <string>
#include <iostream>
#include "NPC.h"
#include "DecisionTree.h"
#include "WorkingTree.h"


class Main {
public:
	static std::string state;
	static NPC* npc;
	static WorkingTree workingTree;
};