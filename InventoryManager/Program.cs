using InventoryManager;

Inventory inventory1 = new Inventory();

while (true)
{
    Console.WriteLine("----------------------------");
    foreach (var item in inventory1.GetAllItemsAsStrings())
        Console.WriteLine(item);
    Console.WriteLine("----------------------------\n1.Add  2.Update  3.Delete");
    Console.Write("Choose an option: ");
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter name and type of the item: (1. Weapon 2. Armor 3. Consumable 4. Throwable)");
                var nameToAdd = Console.ReadLine();
                var typeToAdd = int.Parse(Console.ReadLine());
                inventory1.AddItem(nameToAdd, typeToAdd);
                break;
            }
        case 2:
            {
                Console.WriteLine("Choose the ID of the item to update: ");
                var idToUpdate = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the item's new name and type: (1. Weapon 2. Armor 3. Consumable 4. Throwable)");
                var newName = Console.ReadLine();
                var newType = int.Parse(Console.ReadLine());
                inventory1.UpdateItem(idToUpdate, newName, newType);
                break;
            }
        case 3:
            {
                Console.WriteLine("Choose the id of the item to delete: ");
                var idToDelete = int.Parse(Console.ReadLine());
                inventory1.DeleteItem(idToDelete);
                break;
            }
        case 4:
            {
                inventory1.GetAllItemsAsStrings();
                break;
            }
    }
}


