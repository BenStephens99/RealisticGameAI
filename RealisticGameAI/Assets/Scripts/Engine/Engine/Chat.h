#pragma once
#include <string>
#include <vector>


class Chat
{
public:

    std::vector <std::string> type[3];
	Chat(int l, std::vector<std::string> f, std::vector<std::string> n, std::vector<std::string> u);

private: 
	int level;
	std::vector <std::string> friendly;
	std::vector <std::string> neutral;
	std::vector <std::string> unfriendly;

};

