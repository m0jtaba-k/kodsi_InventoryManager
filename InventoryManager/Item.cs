using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Item
    {
        private String name { get; set; }
        private String type { get; }

        public Item(String name, String type)
        {
            this.name = name;
            setType(type);
        }
        public void setType(String type)
        {
            Console.WriteLine("Choose one of the following item types:" +
                "\nA: Weapon\nB: Armour\nC: Consumable\nD:throwable");
            char choice = Console.ReadLine()[0];
            switch (choice)
            {
                case 'A':
                    type = 'Weapon';
                    break;
                case 'B':
                    type = 'Armour';
                    break;
                case 'C':
                    type = 'Consumable';
                    break;
                case 'D':
                    type = 'Throwable';
                    break;
            }
        }



    }
}
