#pragma once
#define MyFunctions _declspec(dllexport)

#include <comdef.h>
#include <string>
#include <iostream>
#include <string>
#include "NPC.h"
#include "DecisionTree.h"
#include "WorkingTree.h"
#include "IdleTree.h"


class Main {
public:
	static const char* state;
	static NPC* npc;
	static WorkingTree workingTree;
	static IdleTree idleTree;
};