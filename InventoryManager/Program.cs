using InventoryManager;

Inventory inventory1 = new Inventory();

while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add an item" +
        "\n2.Update an item" +
        "\n3.Delete an item" +
        "\n4.List all items");
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Item i1 = new Item();
                inventory1.addItem(i1);
                break;
            }
        case 2:
            {

            }
    }
}


