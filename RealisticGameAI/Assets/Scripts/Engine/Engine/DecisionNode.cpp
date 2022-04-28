#include "DecisionNode.h"
#include "Main.h"

DecisionNode::DecisionNode(DecisionNode* left, DecisionNode* right, std::string out)
{
	assignLeft(left);
	assignRight(right);
	assignOutput(out);
}

DecisionNode::DecisionNode(DecisionNode* left, std::string out)
{
	assignLeft(left);
	rightNode = NULL;
	assignOutput(out);
}

DecisionNode::DecisionNode(DecisionNode* left, DecisionNode* right)
{
	assignLeft(left);
	assignRight(right);
}

DecisionNode::DecisionNode(std::string out)
{
	leftNode = NULL;
	rightNode = NULL;
	assignOutput(out);
}

DecisionNode* DecisionNode::Evaluate()
{
	return NULL;
}

void DecisionNode::assignLeft(DecisionNode* l)
{
	leftNode = l;
}

void DecisionNode::assignRight(DecisionNode* r)
{
	rightNode = r;
}

void DecisionNode::assignOutput(std::string o)
{
	output = o;
}
