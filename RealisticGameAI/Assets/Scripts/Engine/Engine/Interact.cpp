#include "Interact.h"

Chat* Interact::ST1 = new Chat(
	 1, 
	 {"Hi!", "Hey you!", "Whats up!"},
	 {"Hello", "Hi", "Hey"},
	 {"Yes?", "Oh its you", "What?"}
 ); 





 Chat* Interact::smallTalk[] = { Interact::ST1 }; // 0

 Chat* Interact::baristaTalk[] = { Interact::ST1 }; // 1

 Chat* Interact::merchantTalk[] = { Interact::ST1 }; // 2

 Chat* Interact::customerTalk[] = { Interact::ST1 };

 Chat* Interact::situations[] = { *Interact::smallTalk, *Interact::baristaTalk,
		*Interact::merchantTalk, *Interact::customerTalk };

 
std::string Interact::talk(int t, int l, double f)
{
	int n;
	if (f >= 0.8) {
		n = 0;
	}
	else if (f >= 0.2 && f <= 0.79) {
		n = 1;
	}
	else {
		n = 2;
	}

	srand((unsigned)time(0));
	int i;
	i = rand() % Interact::smallTalk[l]->type[n].size();

	return Interact::situations[t]->type[n][i];

} 