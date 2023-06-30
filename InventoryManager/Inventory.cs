namespace InventoryManager
{
    public class Inventory
    {
        private int currentSize;
        List<Item> items = new List<Item>();

        public void addItem(Item item)
        {
             items.Add(item);
        }

        public void deleteItem(Item item)
        {
            items.Remove(item);
            Console.WriteLine("item removed from inventory");
        }

        public void updateItem(Item item)
        {
            Console.WriteLine("name the item you want to update");
            items.Find
            item.setName(Console.ReadLine());
            item.setType(Console.ReadLine());
        }

        public Item readItem(Item item)
        {
            return item;
        }
    }
}
