using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    //TODO Add your custom Weapon Types here!
    public enum WeaponType
    {
        Melee,//example weapon types, these do not have to be kept.
        Ranged
    }

    //TODO Add your custom Player Classes here!
    public enum PlayerClass
    {
        Delta,
        Alpha_Delta,
        Phi,
        Alpha_Phi,
        Sigma,
        Alpha_Sigma,
        Epsilon,
        Alpha_Epsilon,
        Gamma,
        Alpha_Gamma,
        Theta,
        Alpha_Theta,
        Tau,
        Alpha_Tau
    }

    //Define stats the Player is able to have. Change these all you like.
    public enum PlayerStat
    {
        Defense,
        Engineering,
        Ingenuity,
        Power,
        Hardiness,
        Stealth,
        Speech,
        Sight,
        Throwables,
        Swords,
        Misc_Melee,
        Sniper_Rifles,
        Explosives,
        Small_Arms,
        Heavy_Arms
    }

    //The 4 directions the player is able to move.
    //WARNING: DO NOT CHANGE ORDER OF LABELS. IF YOU DO BAD THINGS WILL OCCUR!
    //(if you do wish to change the labels, ensure you go with this order -- up, down, right, left)
    public enum Directions
    {
        North,
        South,
        East,
        West
    }

    //These are types of interactions items can have. You can change these, provided you know what you're doing
    public enum InteractionType
    {
        HealPlayer,
        BoostPlayerStat,
        UsedInPuzzle
    }

    //Do not change under any circumstances! Valuable data required for the function of all Text and Text Based Systems
    //within Grump. If you change, and have weird results, you have no one to blame but yourself.
    public enum Tag
    {
        Environmental_Description = 100,
        On_Tile_Enter,
        On_Tile_Exit,
        On_Entity_Interact,
        On_Map_Load,
        On_Map_Enter,
        Dialogue_Tree_Response,
        Dialogue_Tree_Choice,
        Dialogue_Tree_End,        
        Combat_Start_Line,
        Enemy_Death_Line,
        Enemy_Player_Killed_Line,
        Mid_Combat_Line,
    }

    //DIRE WARNING: DO NOT MESS WITH THESE TAGS UNLESS YOU ARE ADDING A NEW EVENT TO THE SYSTEM! DELETING AN EVENT COULD HAVE
    //UNEXEPCTED CONSEQUENCES! DO NOT CHANGE THEIR ORDER EITHER, OR ELSE THERE COULD BE STRANGE RESULTS!
    public enum EventHandle
    {
        On_Tile_Enter,
        On_Tile_Exit,
        On_Entity_Interact,
        On_Entity_Disinteract,
        On_Map_Load,
        On_Item_Added,
        On_Item_Removed,
        On_Item_Used,
        On_Enemy_Killed,
        On_Enemy_Encountered,
        On_Enemy_Disengage,
        On_Player_Killed,
        On_Player_Attack,
        On_Player_Hit,
        On_Player_Healed,
        On_Player_XP_Granted,
        On_Player_Level_Up,
        On_Weapon_Equipped,
        On_Armor_Equipped,
        On_Weapon_Unequipped,
        On_Armor_Unequipped,
        On_Support_Item_Equipped,
        On_Support_Item_Unequipped,
        On_Game_Start,
        On_Game_Close,
        On_Dialogue_Option_Selected,
        On_Dialogue_Tree_Opened,
        On_Dialogue_Tree_Closed
    }
}
