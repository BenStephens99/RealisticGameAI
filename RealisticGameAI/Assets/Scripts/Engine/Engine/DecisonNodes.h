#pragma once
#include "DecisionNode.h"


class DecisonNodes
{
public:
	class Output : public DecisionNode {
		 
	};

	class Working_Idle : public DecisionNode {
		using DecisionNode::DecisionNode;
		DecisionNode* Evaluate() override;
	};

	class Known_Unknown : public DecisionNode {
		using DecisionNode::DecisionNode;
		DecisionNode* Evaluate() override;
	};

	class Like_Dislike : public DecisionNode {
		using DecisionNode::DecisionNode;
		DecisionNode* Evaluate() override;
	};
	

};

