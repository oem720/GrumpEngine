using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class Weapon : IItem
    {
        //Implement required IEntity Auto-Props
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "Weapon";
        public bool IsGrabbable { get; set; } = true;

        //Implement required IItem Auto-Props
        public string ItemName { get; private set; }
        public string ItemDescription { get; private set; }

        //Member Auto-Props
        public int Damage { get; private set; }
        public float ArmorPenetrationCoefficient { get; private set; }
        public WeaponType WeaponType { get; private set; }

        public Weapon(float weight, string name, int damage, float armorPenetration, string description, WeaponType type)
        {
            Weight = weight;
            ItemName = name;
            Damage = damage;
            ArmorPenetrationCoefficient = armorPenetration;
            ItemDescription = description;
            WeaponType = type;
        }
    }
}
