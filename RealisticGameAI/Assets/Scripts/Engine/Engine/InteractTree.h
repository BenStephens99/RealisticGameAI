#pragma once
#include "DecisionTree.h"

class InteractTree : public DecisionTree
{
	class IdleOrBusy : DecisionTree::Node {
		std::string Evaluate() override;
		std::string out = "continue";
	}; 

	class Working : DecisionTree::Node {
		std::string Evaluate() override;
		std::string out = "continue";
	};
};

