#pragma once
#include "DT.h"
#include <cstddef>

class workingTree : public DT
{
	public:

	workingTree ();

	class node1 : public DT::decisionNode {
	public:
		bool activate() override;
		std::string output() override;
	};


	class node2 : public DT::decisionNode {
	public:
		bool activate() override;
		std::string output() override;
	};


	class node3 : public DT::decisionNode {
	public:


		bool activate() override;
		std::string output() override;
	};


};
