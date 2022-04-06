#pragma once
#include "Chat.h"
#include <time.h>

class Interact
{		
public:
	
	static Chat* ST1;
	static Chat* C2;
	static Chat* C3;
	static Chat* C4;
	static Chat* C5;
	static Chat* C6;
	static Chat* C7;
	static Chat* C8;
	static Chat* C9;

	static Chat* smallTalk[]; 
	static Chat* baristaTalk[]; 
	static Chat* merchantTalk[]; 
	static Chat* customerTalk[];

	static Chat* situations[4];

	static std::string talk(int t, int l, double f);

};

