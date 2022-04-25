#include "Me.h"


Me::Me(std::string n, int i)
{
	id = i;
	name = n;
}

void Me::print()
{
	
}

void Me::updateState(std::string s) 
{
	currentState = s;
}

