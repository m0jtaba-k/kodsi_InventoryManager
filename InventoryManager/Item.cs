namespace InventoryManager
{
    public enum ItemType
    {
        Weapon, Armor, Consumable, Throwable
    }
    public class Item
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public ItemType Type { get; private set; }

        public Item(int id, string name, int type)
        {
            Id = id;
            Name = name.Contains("Nigger") ? throw new Exception("Good Name!") : name;
            Type = (ItemType)(type - 1);
        }

        public void Update(string newName, int newType)
        {
            Name = newName;
            Type = (ItemType)(newType - 1);
        }

        public override string ToString() 
            => $"{Id} - {Name} [{Type}]";
    }
}
