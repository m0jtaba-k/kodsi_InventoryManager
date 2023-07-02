namespace InventoryManager
{
    public class Inventory
    {
        private readonly int maxSize;
        private readonly List<Item> items = new();

        public void AddItem(string name, int type)
        {
            var currentId = !items.Any() ? 1 : items.Max(item => item.Id) + 1;
            items.Add(new(currentId, name, type));
        }

        public void DeleteItem(int id)
        {
            var item = GetItemById(id); 
            items.Remove(item);
        }

        public void UpdateItem(int id, string name, int type)
        {
            var item = GetItemById(id);
            item.Update(name, type);
        }

        public Item GetItemById(int id)
            => items.FirstOrDefault(item => item.Id == id) 
                ?? throw new Exception("Item not found");

        public List<Item> GetAllItems()
        {
            return items;
        }
        public IEnumerable<string> GetAllItemsAsStrings()
        {
            return items.Select(item => item.ToString());
        }
    }
}
