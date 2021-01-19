﻿using System;
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
        Mage,//example player classes, these do not have to be kept
        Barbarian
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

    //Do not change under any circumstances! Valuable data required for the function of all Text and Text Based Systems
    //within Grump. If you change, and have weird results, you have no one to blame but yourself.
    public enum Tag
    {
        Dialogue_Tree_Response = 100,
        Dialogue_Tree_Choice,
        Dialogue_Tree_End,
        Environmental_Description,
        Start_Of_Mid_Combat_Lines,
        Mid_Combat_Line,
        End_Of_Mid_Combat_Line,
        On_Tile_Enter,
        On_Tile_Exit,
        On_Entity_Interact
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
        On_Game_Start,
        On_Game_Close,
        On_Dialogue_Option_Selected,
        On_Dialogue_Tree_Opened,
        On_Dialogue_Tree_Closed
    }
}