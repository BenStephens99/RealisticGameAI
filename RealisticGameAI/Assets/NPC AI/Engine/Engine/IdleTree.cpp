#include "IdleTree.h"
#include "Main.h"

DecisonNodes::Known_Unknown* IdleTree::known_unknown;

DecisonNodes::Like_Dislike* IdleTree::like_dislike;

DecisonNodes::Named_UnNamed* IdleTree::name_noName_liked;
DecisonNodes::Named_UnNamed* IdleTree::name_noName_disliked;

DecisonNodes::LikedPlus_Liked* IdleTree::likedPlus_liked;
DecisonNodes::Disliked* IdleTree::disliked;

DecisonNodes::LikedPlus* IdleTree::likePlus;

IdleTree::IdleTree() {

	std::string Neutral = "Neutral ";
	std::string Negative = "Negative ";
	std::string Positive = "Positive ";
	std::string PositivePlus = "PositivePlus ";
	std::string Name = "Name ";

	likePlus = new DecisonNodes::LikedPlus(PositivePlus + Name);

	disliked = new DecisonNodes::Disliked(Negative + Name);
	likedPlus_liked = new DecisonNodes::LikedPlus_Liked(likePlus, Positive + Name);

	name_noName_disliked = new DecisonNodes::Named_UnNamed(disliked, Negative);
	name_noName_liked = new DecisonNodes::Named_UnNamed(likedPlus_liked, Positive);

	like_dislike = new DecisonNodes::Like_Dislike(name_noName_liked, name_noName_disliked, Neutral);

	known_unknown = new DecisonNodes::Known_Unknown(like_dislike, Neutral);
	rootNode = known_unknown;

}

