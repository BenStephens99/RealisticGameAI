#pragma once
#include "Interaction.h"
#include <string>
#include <iostream>

class Conversation
{
public:
	static Interaction* greeting;
	static Interaction* fairwell;


	static const char* beginConversation(int);
	static int randNum(int a, int b);
};

