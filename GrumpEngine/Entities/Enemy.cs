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
        public int Health { get; set; }
        public float DamageResistance { get; private set; }
        public int Level { get; private set; }
        public DialogueTree Dialogue { get; private set; }
        public bool IsTalkable { get; set; }
        public Inventory Inv { get; set; }
        public Weapon CurrentEquippedWeapon { get; private set; }
        public Armor CurrentEquippedArmor { get; private set; }

        //implement the required properties for IEntity
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "Enemy";
        public bool IsGrabbable { get; set; } = false;

        //Member auto-props
        public string Name { get; private set; }
        public string InspectLine { get; private set; }
        public bool CanUseHealingItem { get; set; }
        public bool IsBoss { get; private set; }
        public bool IsEscapable { get; set; }
        public int XPReward { get; private set; }
        public int GoldReward { get; private set; }
        public List<DescriptorString> MidCombatLines { get; private set; } = new List<DescriptorString>();
        public List<DescriptorString> PlayerDeathResponses { get; private set; } = new List<DescriptorString>();
        public DescriptorString CombatStartLine { get; private set; }
        public DescriptorString EnemyDeathLine { get; private set; }

        //Member fields
        private Random _ran = new Random();

        public Enemy(string name, string inspectline, int health, float dmgresist, int level, int xpreward, int goldreward, Weapon curwep, Armor curarm, bool isboss = false, bool canheal = false, bool isescape = true, bool istalkable = false)
        {
            Name = name;
            InspectLine = inspectline;
            Health = health;
            DamageResistance = dmgresist;
            Level = level;
            XPReward = xpreward;
            GoldReward = goldreward;
            CurrentEquippedArmor = curarm;
            CurrentEquippedWeapon = curwep;
            IsBoss = isboss;
            CanUseHealingItem = canheal;
            IsEscapable = isescape;
            IsTalkable = istalkable;
        }

        public DescriptorString RequestRandomCombatLine()
        {
            return MidCombatLines[_ran.Next(0, MidCombatLines.Count)];
        }

        public DescriptorString RequestRandomDeathResponseLine()
        {
            return PlayerDeathResponses[_ran.Next(0, PlayerDeathResponses.Count)];
        }

        public bool AddMidCombatLine(DescriptorString ds)
        {
            if (ds.Tag.Equals(Tag.Mid_Combat_Line))
            {
                MidCombatLines.Add(ds);
                return true;
            }
            return false;
        }

        public bool SetCombatStartLine(DescriptorString ds)
        {
            if (ds.Tag.Equals(Tag.Combat_Start_Line))
            {
                CombatStartLine = ds;
                return true;
            }
            return false;
        }

        public bool SetEnemyDeathLine(DescriptorString ds)
        {
            if (ds.Tag.Equals(Tag.Enemy_Death_Line))
            {
                EnemyDeathLine = ds;
                return true;
            }
            return false;
        }

        public bool AddPlayerDeathResponse(DescriptorString ds)
        {
            if (ds.Tag.Equals(Tag.Enemy_Player_Killed_Line))
            {
                PlayerDeathResponses.Add(ds);
                return true;
            }
            return false;
        }

        public void AddItemToInventory(IEntity item)
        {
            Inv.AddItem(item);
        }
    }
}
