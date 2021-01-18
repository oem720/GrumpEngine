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
        Melee,
        Ranged
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
}
