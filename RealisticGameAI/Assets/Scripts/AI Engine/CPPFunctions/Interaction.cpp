#include "Interaction.h"

Interaction::Interaction(std::array<std::string, 3> f, std::array<std::string, 3> n, std::array<std::string, 3> u)
{
	friendly = f;
	neutral = n;
	unfriendly = u;
}

