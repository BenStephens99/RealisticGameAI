#pragma once
#include "Interaction.h"
#include <string>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>

class Conversation
{
public:
	static Interaction* greeting;
	static Interaction* fairwell;


	static std::string beginConversation(int);
	static int randNum(int a, int b);
	void Tree();
};

