#pragma once
#define MyFunctions _declspec(dllexport)

#include <comdef.h>
#include <string>
#include <iostream>
#include "BST.h"
#include "NPC.h"
#include "Me.h"
#include "NN.h"

class Main {
public:
	static Me* me;
	static NPC* npc;
	static BST Tree;
	static NN nn;
};