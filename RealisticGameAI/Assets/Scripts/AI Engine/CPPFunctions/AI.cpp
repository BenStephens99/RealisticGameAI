#include "AI.h"
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

MyFunctions int AddNumbers(int a, int b)
	{
		return a;
	}

MyFunctions int init(int a, int b)
	{

	initInteractions();

	}
}

void initInteractions() {

	static Interaction* greeting = new Interaction({ "Hi! How are you?", "Hello! Whats up?", "Hey! How you doing?" },
		{ "Hi", "Hello", "Hey" },
		{ "Oh It's you", "Go Away", "Ughh" });

}

