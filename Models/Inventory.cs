using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Controller;

namespace InventoryManagementSystem.Models
{
    internal class Inventory
    {
        public static void InventoryMenu()
        {
            while (true)
            {
                Console.WriteLine("Which menu do you want?\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ProductStore.DisplayMenu();
                        break;
                    case 2:
                        SupplyStore.DisplayMenu();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    
                }
            }
        }
        
       
        
    }
}
