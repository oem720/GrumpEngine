using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GrumpEngine
{
    public class PositionBasedEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Dir { get; set; }
    }

    public static class EventCoordinator
    {
        public static Map Map { get; set; }

        public static void RaiseEvent(object sender, EventHandle handle)
        {
            typeof(EventCoordinator).GetMethod(handle.ToString()).Invoke(null, new[] { sender, new EventArgs() });
        }

        public static void RaiseEvent(object sender, EventHandle handle, GridPoint pos, Directions dir)
        {
            PositionBasedEventArgs pbea = new PositionBasedEventArgs();
            pbea.X = pos.X;
            pbea.Y = pos.Y;
            pbea.Dir = dir;
            typeof(EventCoordinator).GetMethod(handle.ToString()).Invoke(null, new[] { sender, pbea });
        }

        private static void On_Tile_Enter(object sender, PositionBasedEventArgs pbea)
        {

        }

        private static void On_Tile_Exit(object sender, PositionBasedEventArgs pbea)
        {

        }

        private static void On_Entity_Interact(object sender, EventArgs e)
        {

        }

        private static void On_Entity_Disinteract(object sender, EventArgs e)
        {

        }

        private static void On_Map_Load(object sender, EventArgs e)
        {

        }

        private static void On_Item_Added(object sender, EventArgs e)
        {

        }

        private static void On_Item_Removed(object sender, EventArgs e)
        {

        }

        private static void On_Item_Used(object sender, EventArgs e)
        {

        }

        private static void On_Enemy_Killed(object sender, EventArgs e)
        {

        }

        private static void On_Enemy_Encountered(object sender, EventArgs e)
        {

        }

        private static void On_Enemy_Disengage(object sender, EventArgs e)
        {

        }

        private static void On_Player_Killed(object sender, EventArgs e)
        {

        }

        private static void On_Player_Attack(object sender, EventArgs e)
        {

        }

        private static void On_Player_Hit(object sender, EventArgs e)
        {

        }

        private static void On_Player_Healed(object sender, EventArgs e)
        {

        }

        private static void On_Player_XP_Granted(object sender, EventArgs e)
        {

        }

        private static void On_Player_Level_Up(object sender, EventArgs e)
        {

        }

        private static void On_Weapon_Equipped(object sender, EventArgs e)
        {

        }

        private static void On_Armor_Equipped(object sender, EventArgs e)
        {

        }

        private static void On_Weapon_Unequipped(object sender, EventArgs e)
        {

        }

        private static void On_Armor_Unequipped(object sender, EventArgs e)
        {

        }

        private static void On_Game_Start(object sender, EventArgs e)
        {

        }

        private static void On_Game_Close(object sender, EventArgs e)
        {

        }

        private static void On_Dialogue_Option_Selected(object sender, EventArgs e)
        {

        }

        private static void On_Dialogue_Tree_Opened(object sender, EventArgs e)
        {

        }

        private static void On_Dialogue_Tree_Closed(object sender, EventArgs e)
        {

        }
    }
}
