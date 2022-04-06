#include "Chat.h"
#include <time.h>

Chat::Chat(int l, std::vector<std::string> f, std::vector<std::string> n, std::vector<std::string> u)
{
	level = l;
	friendly = f;
	neutral = n;
	unfriendly = u;

	type[0] = friendly;
	type[1] = neutral;
	type[2] = unfriendly;
}


