#pragma once
#include "DecisionTree.h"

class TreeApproached : public DecisionTree
{
public:
	TreeApproached();

	static DecisonNodes::Working_Idle* working_idle;
	static DecisonNodes::Known_Unknown* known_unknown;
	static DecisonNodes::Like_Dislike* like_dislike;


};s

