#include "AI.h"
#include <comdef.h>
#pragma once
#define MyFunctions _declspec(dllexport)

extern "C" {

	struct NPCDetails {
		int age;
		int appiness;

	} _npcDetails;

MyFunctions int SubtractNumbers(int a, int b)
	{	

		int c = a - b;
		return 100;
	}

MyFunctions BSTR talk(int a)
	{

		return SysAllocString(_bstr_t(Conversation::beginConversation(a).c_str()).Detach());
	} 

MyFunctions int init(int a, int b)
	{

	return a * b;

	}
}


