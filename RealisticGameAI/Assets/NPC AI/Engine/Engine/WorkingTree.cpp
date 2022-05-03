#include "WorkingTree.h"
#include "Main.h"

DecisonNodes::Known_Unknown* WorkingTree::known_unknown;

DecisonNodes::Like_Dislike* WorkingTree::like_dislike;

DecisonNodes::Named_UnNamed* WorkingTree::name_noName_liked;
DecisonNodes::Named_UnNamed* WorkingTree::name_noName_disliked;

DecisonNodes::LikedPlus_Liked* WorkingTree::likedPlus_liked;
DecisonNodes::Disliked* WorkingTree::disliked;

DecisonNodes::LikedPlus* WorkingTree::likePlus;

WorkingTree::WorkingTree() {
	
	std::string Serve = "Serve ";
	std::string No_Serve = "No Serve ";
	std::string Discount = "Discount ";
	std::string Name = Main::npc.name;
	
	likePlus = new DecisonNodes::LikedPlus(Serve + Name + Discount);

	disliked = new DecisonNodes::Disliked(No_Serve + Name);
	likedPlus_liked = new DecisonNodes::LikedPlus_Liked(likePlus, Serve + Name);

	name_noName_disliked = new DecisonNodes::Named_UnNamed(disliked, No_Serve);
	name_noName_liked = new DecisonNodes::Named_UnNamed(likedPlus_liked, Serve);

	like_dislike = new DecisonNodes::Like_Dislike(name_noName_liked, name_noName_disliked, Serve); 

	known_unknown = new DecisonNodes::Known_Unknown(like_dislike, Serve);
	rootNode = known_unknown; 

}

