#include "Me.h"

Me::Me(int _id, const char* _name, const char* _job, int _start, int _finish, int _days[7])
{
	idNum = _id;
	name = _name;
	job.name = _job;
	job.start = _start;
	job.end = _finish;
	friendliness = 10;

	for (int i = 0; i < 7; i++) {
		job.days[i] = _days[i];
	}
}

Me::Me() {
	idNum = NULL;
	name = "";
	job.name = "";
	job.start = NULL;
	job.end = NULL;
	friendliness = NULL;
}

void Me::print()
{
	std::cout << "Id: " << idNum << std::endl;
	std::cout << "Name: " << name << std::endl;
	std::cout << "Friendliness: " << friendliness << std::endl;	
	std::cout << "Job: " << job.name << std::endl;
	std::cout << "Start time: " << job.start << std::endl;
	std::cout << "End Time: "<< job.end << std::endl;
	for (int i = 0; i < 7; i++) {
		std::cout << "Working days: " << job.days[i] << std::endl;
	}
}

