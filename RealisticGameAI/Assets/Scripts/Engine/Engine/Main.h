#pragma once
#define MyFunctions _declspec(dllexport)

#include <comdef.h>
#include <string>
#include <iostream>
#include "BST.h"
#include "NPC.h"
#include "Me.h"
#include "DT.h"
#include "walkPastTree.h"
#include "workingTree.h"

class Main {
public:
	static Me* me;
	static NPC* npc;
	static BST BST;
	static walkPastTree WalkPastTree;
	static workingTree WorkingTree;
};