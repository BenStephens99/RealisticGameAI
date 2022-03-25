#pragma once
#include "AI.h"
#include <array>

class Interaction {

public:

	Interaction(std::array < std::string, 3 > f, 
				std::array < std::string, 3 > n,
				std::array < std::string, 3 > u);


	static std::array < std::string, 3 > friendly;
	static std::array < std::string, 3 > neutral;
	static std::array < std::string, 3 > unfriendly;

};