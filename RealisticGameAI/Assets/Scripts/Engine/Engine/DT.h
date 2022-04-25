#pragma once
#include <string>
#include <vector>


class DT
{	
public:

	class decisionNode
	{
	public:
		bool virtual activate();

		std::string virtual output();

	};

	DT();

	std::vector <decisionNode*> nodes;

	virtual std::string start(int npcID);

};


