#pragma once
#include "DecisionTree.h" 

class IdleTree : public DecisionTree
{
public:
	IdleTree();

	static DecisonNodes::Known_Unknown* known_unknown;

	static DecisonNodes::Like_Dislike* like_dislike;

	static DecisonNodes::Named_UnNamed* name_noName_liked;
	static DecisonNodes::Named_UnNamed* name_noName_disliked;

	static DecisonNodes::LikedPlus_Liked* likedPlus_liked;
	static DecisonNodes::Disliked* disliked;;

	static DecisonNodes::LikedPlus* likePlus;
};

