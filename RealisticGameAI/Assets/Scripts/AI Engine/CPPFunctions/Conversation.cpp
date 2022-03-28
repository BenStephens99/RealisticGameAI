#include "Conversation.h"
#include <stdio.h>
#include <stdlib.h>


	Interaction* Conversation::greeting = new Interaction(
	{ "Hi! How are you?", "Hello! Whats up?", "Hey! How you doing?" },
	{ "Hi", "Hello", "Hey" },
	{ "Oh It's you", "Go Away", "Ughh" });

	Interaction* Conversation::fairwell = new Interaction(
	{ "See you soon", "Bye for now", "Have a nice day" },
	{ "Goodbye", "Fairwell", "Bye" },
	{ "Good Riddance.", "I'm out.", "Ughh" });

	std::string Conversation::beginConversation(int a) {
		if (a > 3) {
			return greeting->friendly[randNum(0, 3)];
		}
		else {
			return greeting->unfriendly[randNum(0, 3)];
		}
	}

	int Conversation::randNum(int a, int b) {
		srand((unsigned)time(0));
		int result = a + (rand() % b);
		return result;
	} 

	void Conversation::Tree() {
		
	}

	class conversationTree {
	public:

		class Node {
		public:
			 Interaction* interaction;
			 Node* left;
			 Node* right;
		};

		 Node* root;

		 conversationTree() {
			 root = NULL;
		 }
		 
		 void Insert(Interaction* interaction) {
			 Node* newNode = new Node();
			 newNode->interaction = interaction;
			 if (root == NULL) {
				 root = newNode;
			 }
			 else {
				 Node* current = root;
				 Node* parent;

				 while (true) {
					 parent = current;
					 if (interaction < current->interaction) {
						 parent->left = newNode;
						 break;
					 }
					 else {
						 current = current->right;
						 if (current == NULL) {
							 parent->right = newNode;
							 break;
						 }
					 }
				 }
			 } 
		 }
		 

	};