#pragma once
#include <string>

class DecisionNode
{
public:
	DecisionNode(DecisionNode* left, DecisionNode* right, std::string output);
	DecisionNode(DecisionNode* left, std::string output);
	DecisionNode(DecisionNode* left, DecisionNode* right);
	DecisionNode(std::string output);

	virtual DecisionNode* Evaluate();

	DecisionNode* leftNode;
	DecisionNode* rightNode;
	
	std::string output;

	virtual void assignLeft(DecisionNode* left);
	virtual void assignRight(DecisionNode* right);
	virtual void assignOutput(std::string output);



};

