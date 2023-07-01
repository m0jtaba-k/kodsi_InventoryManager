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
            Name = name.Contains("Nigger") ? throw new Exception("You can't say that") : name;
            Type = (ItemType)type;
        }

        public void Update(string newName, int newType)
        {
            Name = newName;
            Type = (ItemType)newType;
        }

        public override string ToString() 
            => $"{Id} - {Name} [{Type}]";
    }
}
