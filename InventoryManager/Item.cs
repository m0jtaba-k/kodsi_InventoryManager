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
        private String type { get; set; }

        public Item()
        {
            setName(name);
            setType(type);
        }

        public String getName() 
        {
            return name;
        }

        public void setName(String name) 
        {
            Console.WriteLine("enter the item's name");
            this.name = Console.ReadLine();
        }
        public void setType(String type)
        {
            Console.WriteLine("Choose one of the following item types:" +
                "\nA: Weapon\nB: Armour\nC: Consumable\nD:throwable");
            char choice = Console.ReadLine()[0];
            switch (choice)
            {
                case 'A':
                    this.type = "Weapon";
                    break;
                case 'B':
                    this.type = "Armour";
                    break;
                case 'C':
                    this.type = "Consumable";
                    break;
                case 'D':
                    this.type = "Throwable";
                    break;
            }
        }

        override
            public string ToString()
        {
            return "item name: " + name
                + "\nitem type: " + type;
        }

    }
}
