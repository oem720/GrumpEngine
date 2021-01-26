using System;

namespace GrumpEngine
{
    [Serializable]
    public class Armor : IEntity
    {
        //Implement required IEntity Auto-props
        public float Weight { get; private set; }
        public string Identifier { get; private set; }
        public bool IsGrabbable { get; set; } = true;

        //Member Auto-props
        public float ArmorResistanceCoefficient { get; private set; }
        public string Description { get; private set; }
    }
}
