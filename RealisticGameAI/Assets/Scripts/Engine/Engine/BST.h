#pragma once
#pragma once
#include <cstddef>
#include <iostream>
#include "NPC.h"

class BST
{

public:


	NPC* root = NULL;

	bool isEmpty();
	void insert(NPC*);

	void print(NPC*, int);

	NPC* search(int);

	static int randNum(int a, int b);

};