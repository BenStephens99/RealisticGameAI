#pragma once
#include <string>
#include <iostream>

class Job {
public:
	std::string name;

	int start;
	int end;
	int days[7];
};

class Me {
public:
	Me(int, const char*, const char*, int, int, int[7]);

	Me();

	int idNum;
	std::string name;
	std::string state = "Idle";
	Job job;
	int friendliness;
	std::string sex;

	void print();
	
};

