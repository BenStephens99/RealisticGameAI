#pragma once
#include <string>
#include <iostream>
#include "DecisonNodes.h"


class DecisionTree
{
public:
	DecisionTree();

	DecisionNode* rootNode;
	DecisionNode* currentNode;	
	std::string output;


	virtual std::string start();

	

};

