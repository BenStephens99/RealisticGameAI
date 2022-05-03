#include "DecisionTree.h"
DecisionTree::DecisionTree()
{
	rootNode = NULL;
	currentNode = NULL;
}

std::string DecisionTree::start()
{
	currentNode = rootNode;

	while (currentNode != NULL) {
		output = currentNode->output;
		currentNode = currentNode->Evaluate();
	}
	

	return output;
}
