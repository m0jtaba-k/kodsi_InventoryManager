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
        }

        public void updateItem(Item item)
        {

        }
    }
}
