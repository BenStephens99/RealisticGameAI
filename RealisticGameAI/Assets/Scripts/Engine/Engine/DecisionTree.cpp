#include "DecisionTree.h"

DecisionTree::DecisionTree()
{
	root = NULL;
}

void DecisionTree::attatchNodes(Node* root, Node* left, Node* right)
{
	if (root->left == NULL) {
		root->left = left;
	}
	else {
		std::cout << "node already at left" << std::endl;
	}

	if (root->right == NULL) {
		root->right = right;
	}
	else {
		std::cout << "node already at right" << std::endl;
	}
}

void DecisionTree::attatchNodes(Node* root, Node* node)
{
	if (root->left == NULL) {
		root->left = node;
	}
	else if (root->right == NULL) {
		root->right = node;
	}
	else {
		std::cout << "No nodes Available";
	}
}

std::string DecisionTree::start()
{
	std::string output;
	while (output == "Empty") {
		std::string evaluation;

		if (evaluation == "Left") {
			root = root->left;
		}
		else if (evaluation == "Right") {
			root = root->right;
		}
		else
		{
			evaluation = output;
		}
	}
	return output;
		
}

DecisionTree::Node::Node()
{
	left = NULL;
	right = NULL;
	out = "No Out";
}

std::string DecisionTree::Node::Evaluate()
{
	return "No Output";
}
