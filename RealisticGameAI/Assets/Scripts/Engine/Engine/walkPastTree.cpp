#include "walkPastTree.h"
#include "Main.h"
#include <iostream>

walkPastTree::walkPastTree()
{
    node0* n0 = new node0();
    node01* n01 = new node01();
    node1* n1 = new node1();
    node2* n2 = new node2();
    node3* n3 = new node3();

    nodes.push_back(n0);
    nodes.push_back(n01);
    nodes.push_back(n1);
    nodes.push_back(n2);
    nodes.push_back(n3);
} 

bool walkPastTree::node0::activate()
{
    if (Main::npc == NULL) {
        return false; // output
    }
    else {
        return true; // nextnode
    }
}
std::string walkPastTree::node0::output()
{
    return "continue";
}

bool walkPastTree::node01::activate() {
    if (Main::npc->relationship > 40) {
        return true;
    }
    else {
        return false;
    }
}
std::string walkPastTree::node01::output()
{
    return "continue";
}

bool walkPastTree::node1::activate()
{

    if (Main::me->currentState != "Working") {
        return true; //nextnode
    }
    else {
        return false; // output
    }
}
std::string walkPastTree::node1::output()
{
    return "Hey There";
}


bool walkPastTree::node2::activate()
{   
    if (Main::npc->relationship > 60) {
        return true; 
    } 
    else {
        return false;
    }
}
std::string walkPastTree::node2::output()
{
   return "Hey there " + Main::npc->name;
}

bool walkPastTree::node3::activate()
{
    return false;
}
std::string walkPastTree::node3::output()
{
    return "Start Conversation";
}