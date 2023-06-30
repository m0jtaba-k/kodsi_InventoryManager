using InventoryManager;

Inventory inventory1 = new Inventory();
Item I1 = new Item();

inventory1.addItem(I1);
Console.WriteLine(I1.ToString());
inventory1.updateItem(I1);
Console.WriteLine(I1.ToString());
inventory1.deleteItem(I1);


