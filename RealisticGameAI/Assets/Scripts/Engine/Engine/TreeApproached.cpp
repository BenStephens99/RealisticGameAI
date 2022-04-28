#include "TreeApproached.h"


DecisonNodes::Working_Idle* TreeApproached::working_idle;
DecisonNodes::Known_Unknown* TreeApproached::known_unknown;
DecisonNodes::Like_Dislike* TreeApproached::like_dislike;

TreeApproached::TreeApproached()
{
	like_dislike = new DecisonNodes::Like_Dislike("Neutral");
	known_unknown = new DecisonNodes::Known_Unknown(like_dislike, like_dislike, );
	working_idle = new DecisonNodes::Working_Idle(known_unknown, known_unknown);
	rootNode = working_idle;


}
 