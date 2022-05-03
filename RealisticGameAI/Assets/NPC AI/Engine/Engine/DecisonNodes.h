#pragma once
#include "DecisionNode.h"


class DecisonNodes
{
public:

	class Known_Unknown : public DecisionNode {
		using DecisionNode::DecisionNode;
		DecisionNode* Evaluate() override;
	};

	class Like_Dislike : public DecisionNode {
		using DecisionNode::DecisionNode;
		DecisionNode* Evaluate() override;
	};
	
	class Named_UnNamed : public DecisionNode {
		using DecisionNode::DecisionNode;
		DecisionNode* Evaluate() override;
	};

	class LikedPlus_Liked : public DecisionNode {
		using DecisionNode::DecisionNode;
		DecisionNode* Evaluate() override;
	};

	class LikedPlus : public DecisionNode {
		using DecisionNode::DecisionNode;
	};

	class Disliked : public DecisionNode {
		using DecisionNode::DecisionNode;
	};
};

