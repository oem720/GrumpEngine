using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class AssistItem : IItem
    {
        //Implement required IEntity Auto-Props
        public float Weight { get; private set; }
        public string Identifier { get; private set; } = "UseableItem";
        public bool IsGrabbable { get; set; }

        //Implement required IItem Auto-Props
        public string ItemName { get; private set; }
        public string ItemDescription { get; private set; }

        //Member Auto-Props
        public KeyValuePair<PlayerStat, int> Bonus { get; private set; }

        public AssistItem(string name, string desc, PlayerStat stattype, int bonus)
        {
            ItemName = name;
            ItemDescription = desc;
            Bonus = new KeyValuePair<PlayerStat, int>(stattype, bonus);
        }
    }
}
