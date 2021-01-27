using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    [Serializable]
    public class UseableItem : IItem
    {
        //Implement required IEntity Auto-Props
        public float Weight { get; private set; }
        public string Identifier { get; private set; } = "UseableItem";
        public bool IsGrabbable { get; set; }

        //Implement required IItem Auto-Props
        public string ItemName { get; private set; }
        public string ItemDescription { get; private set; }

        //Member Auto-props
        public InteractionType UseCase { get; private set; }
        public int HealthGranted { get; private set; }
        public KeyValuePair<PlayerStat, int> StatBoostGranted { get; private set; }
        public EnvironmentInteractableItem ItemUsedWith { get; private set; }

        public UseableItem(string name, string desc, float weight, InteractionType use, bool isgrabbable = true, int health = 0, KeyValuePair<PlayerStat, int> stat = default, EnvironmentInteractableItem item = null)
        {
            ItemName = name;
            ItemDescription = desc;
            Weight = weight;
            IsGrabbable = isgrabbable;
            UseCase = use;
            HealthGranted = health;
            StatBoostGranted = stat;
            ItemUsedWith = item;
        }

        public void Use()
        {
            switch (UseCase)
            {
                case InteractionType.HealPlayer:
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Item_Used);
                    Globals.Player.Heal(HealthGranted);                    
                    break;
                case InteractionType.BoostPlayerStat:
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Item_Used);
                    //TODO: During fight, this will give a boost to a specific stat *only* during the fight in which it is used
                    break;
                case InteractionType.UsedInPuzzle:
                    EventCoordinator.RaiseEvent(this, EventHandle.On_Item_Used);
                    //TODO: Out of fight, this will be enabled to fire
                    break;
            }
        }
    }
}
