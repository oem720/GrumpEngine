namespace GrumpEngine
{
    public interface ICharacter : IEntity
    {
        int Health { get; }
        float DamageResistance { get; }
        int Level { get; }
        DialogueTree Dialogue { get; }
        bool IsTalkable { get; }
        Inventory Inv { get; }
        Weapon CurrentEquippedWeapon { get; }
        Armor CurrentEquippedArmor { get; }
    }
}
