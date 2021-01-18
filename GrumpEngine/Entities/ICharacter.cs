using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    public interface ICharacter : IEntity
    {
        int Health { get; }
        double DamageResistance { get; }
        int Level { get; }
        DialogueTree Dialogue { get; }
        bool IsTalkable { get; }
        Inventory Inv { get; }
    }
}
