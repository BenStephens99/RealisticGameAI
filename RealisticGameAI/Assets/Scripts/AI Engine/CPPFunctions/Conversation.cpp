#include "Conversation.h"

	Interaction* Conversation::greeting = new Interaction(
	{ "Hi! How are you?", "Hello! Whats up?", "Hey! How you doing?" },
	{ "Hi", "Hello", "Hey" },
	{ "Oh It's you", "Go Away", "Ughh" });

	Interaction* Conversation::fairwell = new Interaction(
		{ "Hi! How are you?", "Hello! Whats up?", "Hey! How you doing?" },
		{ "Hi", "Hello", "Hey" },
		{ "Oh It's you", "Go Away", "Ughh" });

		const char* Conversation::beginConversation(int a) {
		if (a > 3) {
			return greeting->friendly[randNum(0, 2)].c_str();
		}
		else {
			return greeting->unfriendly[randNum(0, 2)].c_str();
		}
	}

	int Conversation::randNum(int a, int b) {
		srand((unsigned)time(0));
		int result = a + (rand() % b);
		return result;
	} 