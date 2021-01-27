using System;

namespace GrumpEngine
{
    [Serializable]
    public class Armor : IItem
    {
        //Implement required IEntity Auto-props
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "Armor";
        public bool IsGrabbable { get; set; } = true;

        //Implement required IItem Auto-props
        public string ItemName { get; private set; }
        public string ItemDescription { get; private set; }

        //Member Auto-props
        public float ArmorResistanceCoefficient { get; private set; }

        public Armor (float weight, string name, float armorCoef, string desc)
        {
            Weight = weight;
            ItemName = name;
            ArmorResistanceCoefficient = armorCoef;
            ItemDescription = desc;
        }
    }
}
