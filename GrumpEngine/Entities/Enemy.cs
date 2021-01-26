using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class Enemy : ICharacter
    {
        //implement the required properties for ICharacter
        public int Health { get; private set; }
        public float DamageResistance { get; private set; }
        public int Level { get; private set; }
        public DialogueTree Dialogue { get; private set; }
        public bool IsTalkable { get; private set; }
        public Inventory Inv { get; private set; } = Factory.ConstructInventory(25);
        public Weapon CurrentEquippedWeapon { get; private set; }
        public Armor CurrentEquippedArmor { get; private set; }

        //implement the required properties for IEntity
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "Enemy";
        public bool IsGrabbable { get; set; } = false;

        //Member auto-props
        public string Name { get; private set; }
        public string InspectLine { get; private set; }
        public bool CanUseHealingItem { get; set; } = false;
        public bool IsBoss { get; private set; }
        public DescriptorString[] MidCombatLines { get; private set; }
        public DescriptorString CombatStartLine { get; private set; }

        public Enemy(string name, string inspectLine, int health, int level, float dmgresist, Weapon usedwep, Armor usedarmor, bool isTalkable = false, DialogueTree dt = null, bool canheal = false, bool isboss = false)
        {
            Health = health;
            Level = level;
            DamageResistance = dmgresist;
            CurrentEquippedArmor = usedarmor;
            CurrentEquippedWeapon = usedwep;
            IsTalkable = isTalkable;
            Dialogue = dt;
            Name = name;
            InspectLine = inspectLine;
            CanUseHealingItem = canheal;
            IsBoss = isboss;
        }

        public void AddMidCombatLines(List<DescriptorString> listds)
        {
            MidCombatLines = listds.ToArray();
        }

        public DescriptorString RequestRandomCombatLine()
        {
            Random ran = new Random();
            return MidCombatLines[ran.Next(0, MidCombatLines.Length)];
        }
    }
}
