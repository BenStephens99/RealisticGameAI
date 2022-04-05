#pragma once
#include <string>
#include <iostream>

class NPC
{
public:
	NPC(int);

	int idNum;
	std::string name;
	std::string sex;
	int relationship;

	NPC* left;
	NPC* right;

	void addName(const char*);
};

