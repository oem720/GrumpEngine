﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public class Weapon : IEntity
    {
        //Implement required IEntity Auto-Props
        public float Weight { get; private set; }
        public string Identifier { get; private set; }
        public bool IsGrabbable { get; set; } = true;

        //Member Auto-Props
        public int Damage { get; private set; }
        public float ArmorPenetrationCoefficient { get; private set; }
        public string Description { get; private set; }
        public WeaponType WeaponType { get; private set; }

        public Weapon(float weight, string identifier, int damage, float armorPenetration, string description, WeaponType type)
        {
            Weight = weight;
            Identifier = identifier;
            Damage = damage;
            ArmorPenetrationCoefficient = armorPenetration;
            Description = description;
            WeaponType = type;
        }
    }
}