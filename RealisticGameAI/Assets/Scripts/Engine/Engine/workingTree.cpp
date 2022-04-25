#include "workingTree.h"
#include "Main.h"

workingTree::workingTree()
{
    node1* rn = new node1();
    node2* in = new node2();
    node3* cn = new node3();

    nodes.push_back(rn);
    nodes.push_back(in);
    nodes.push_back(cn);
}

bool workingTree::node1::activate()
{
    if (Main::npc != NULL) {
        return false;
    }
    else {
        return true;
    }
}
std::string workingTree::node1::output()
{
    return "continue";
}


bool workingTree::node2::activate()
{
    if (Main::me->currentState == "Working") {
        return false;
    }
    else {
        return true;
    }
}
std::string workingTree::node2::output()
{
    return "Hey there";
}

bool workingTree::node3::activate()
{
    return false;
}
std::string workingTree::node3::output()
{
    return "Begin Conversation";
}
