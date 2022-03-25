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
		return a;
	}

MyFunctions BSTR talk(int a)
	{
		return SysAllocString(L"Ben");
	} 

MyFunctions int init(int a, int b)
	{

	return a + b;

	}
}


