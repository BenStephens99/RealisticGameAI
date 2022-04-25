#include "DT.h"
#include "Main.h" 
#include <iostream>


bool DT::decisionNode::activate()
{
	return false;
}

std::string DT::decisionNode::output()
{
	return "continue";
}

DT::DT()
{
}

std::string DT::start(int id) 
{
	
	Main::npc = Main::BST.search(id);
	

	for (int i = 0; i < nodes.size(); i++) {
		if (nodes[i]->activate() == false)  
		{
			return nodes[i]->output();
		}
	}
	return "continue";
}


