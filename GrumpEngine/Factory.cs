namespace GrumpEngine
{
    public static class Factory
    {
        //contains constructors for all types created in this library. Use this to construct instances of each item.
        public static Tile ConstructTile()
        {
            return new Tile();
        }

        public static Player ConstructPlayer(GridPoint pos, string name)
        {
            return new Player(pos, name);
        }

        public static Weapon ConstructWeapon(float weight, string identifier, int damage, float armorPenetration, string description, WeaponType type)
        {
            return new Weapon(weight, identifier, damage, armorPenetration, description, type);
        }

        public static Inventory ConstructInventory(int size = 0)
        {
            return new Inventory(size);
        }

        public static DialogueTree ConstructDialogueTree()
        {
            return new DialogueTree();
        }

        public static ResizeableMatrix<T> ConstructResizeableMatrix<T>(int row, int col)
        {
            return new ResizeableMatrix<T>(row, col);
        }

        public static GridPoint ConstructGridPoint(int x, int y)
        {
            return new GridPoint(x, y);
        }

        public static Armor ConstructArmor(float weight, string identifier, float armorCoef, string desc)
        {
            return new Armor(weight, identifier, armorCoef, desc);
        }
    }
}
