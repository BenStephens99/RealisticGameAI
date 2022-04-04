#include "BST.h"
#include "NPC.h"
#include <iostream>

int duplicates = 0;

bool BST::isEmpty()
{
	if (root == NULL) {
		return true;
	}
	else {
		return false;
	}
}

void BST::insert(NPC* newNPC)
{
	if (root == NULL) {
		root = newNPC;
	}
	else {
		NPC* temp = root;
		while (temp != NULL) {
			if (newNPC->idNum == temp->idNum) {
				return;
			}
			else if ((newNPC->idNum < temp->idNum) && (temp->left == NULL)) {
				temp->left = newNPC;
				break;
			}
			else if (newNPC->idNum < newNPC->idNum) {
				temp = temp->left;
			}
			else if ((newNPC->idNum > temp->idNum) && (temp->right == NULL)) {
				temp->right = newNPC;
				break;
			}
			else {
				temp = temp->right;
			}
		}
	}

}

void BST::print(NPC* r, int num)
{
	if (r == NULL) {
		return;
	}
	num += 10;
	print(r->right, num);
	std::cout << std::endl;
	for (int i = 10; i < num; i++) {
		std::cout << " ";
	}
	std::cout << r->idNum << std::endl;
	print(r->left, num);
}

NPC* BST::search(int id)
{
	if (root == NULL) {
		return root;
	}
	else {
		NPC* temp = root;
		while (temp != NULL) {
			if (id == temp->idNum) {
				return temp;
			}
			else if (id < temp->idNum) {
				temp = temp->left;
			}
			else {
				temp = temp->right;
			}
		}
		return NULL;
	}
}


int BST::randNum(int a, int b) {

	int result = a + (rand() % b);
	return result;
}