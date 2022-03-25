#pragma once

#include <array>
#include <string>
#include <iostream>

class Interaction
{

	public:

		Interaction(std::array < std::string, 3 > f,
			std::array < std::string, 3 > n,
			std::array < std::string, 3 > u);


		 std::array < std::string, 3 > friendly;
		 std::array < std::string, 3 > neutral;
		 std::array < std::string, 3 > unfriendly;

	};


