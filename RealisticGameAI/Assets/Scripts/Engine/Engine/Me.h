#pragma once
#include <string>
#include <iostream>

class Me {
public:
	
	Me(std::string name, int id);

	std::string name;
	int id; 
	std::string currentState;

	void print();

	void updateState(std::string);
	
};

