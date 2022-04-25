#pragma once
#include "DT.h"
#include <cstddef>


class walkPastTree : public DT
{
	public: 

	walkPastTree();

	class node0 : public DT::decisionNode {
	public:
		bool activate() override;
		std::string output() override;
	};

	class node01 : public DT::decisionNode {
		bool activate() override;
		std::string output() override;
	};

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

