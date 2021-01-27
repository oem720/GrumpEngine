using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class GenericItem : IItem
    {
        //Implement required IEntity Auto-Props
        public float Weight { get; private set; }
        public string Identifier { get; private set; } = "GenericItem";
        public bool IsGrabbable { get; set; }

        //Implement required IItem Auto-Props
        public string ItemName { get; private set; }
        public string ItemDescription { get; private set; }

        public GenericItem(string name, string desc, float weight, bool isgrabbable = true)
        {
            ItemName = name;
            ItemDescription = desc;
            Weight = weight;
            IsGrabbable = isgrabbable;
        }
    }
}
