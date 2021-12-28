using Exercise3.Interfaces;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Handlers
{
    public class Menu : IMenu
    {

        public ListHandler listHandler = new();
        public ProductHandler productHandler = new();
        public List<ProductModel> almostDB = new();

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Lägg till en produkt");
            Console.WriteLine("2. Visa hela katalogen");
            Console.WriteLine("3. Visa spec. produkt");
            Console.WriteLine("4. Ta bort produkt");
            Console.WriteLine("9. Avsluta programmet");
            Console.WriteLine("\n Tryck på '0' för att visa menyvalen igen");
        }

        public void GetMenuItem()
        {
            char MenuPick;
            do
            {
                ProductModel ProductItem = new();
                MenuPick = (Console.ReadKey().KeyChar);
                switch (MenuPick)
                {
                    case '1':

                        productHandler.Poke(ProductItem);
                        listHandler.Write(ProductItem, almostDB);
                        break;
                    case '2':
                        Console.WriteLine("Menu choice #2");
                        listHandler.Print(ProductItem, almostDB);
                        break;
                    default:
                        ShowMenu();
                        break;
                }

            } while (MenuPick != '9');

        }
    }
}
