using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class NPC : ICharacter
    {
        //implement the required properties for ICharacter
        public int Health { get; set; }
        public float DamageResistance { get; private set; }
        public int Level { get; private set; }
        public DialogueTree Dialogue { get; private set; } = Factory.ConstructDialogueTree();
        public bool IsTalkable { get; private set; }
        public Inventory Inv { get; private set; } = Factory.ConstructInventory(25);
        public Weapon CurrentEquippedWeapon { get; private set; }
        public Armor CurrentEquippedArmor { get; private set; }

        //implement the required properties for IEntity
        public float Weight { get; private set; } = 0.0f;
        public string Identifier { get; private set; } = "GenericNPC";
        public bool IsGrabbable { get; set; } = false;

        public void AddDialogue(DescriptorString ds)
        {
            Dialogue.AddString(ds);
        }
    }
}
