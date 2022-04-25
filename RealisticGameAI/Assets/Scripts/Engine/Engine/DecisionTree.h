#pragma once
#include <string>
#include <iostream>



class DecisionTree
{
public:
	DecisionTree();

	class Node {
	public:
		Node();
		Node* left;
		Node* right;
		std::string out;

		virtual std::string Evaluate();

	};

	Node* currentNode;

	void attatchNodes(Node* root, Node* left, Node* right);
	void attatchNodes(Node* root, Node* node);

	std::string start();

};

