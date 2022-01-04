using Exercise3.Interfaces;
using Exercise3.Models;

namespace Exercise3.Handlers
{
    public class Menu : IMenu
    {
        public ProductHandler productHandler = new();
        public ListHandler listhandler = new();
        public FileHandler fileHandler = new();

        public List<ProductModel> almostDB = new();

        public static string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ProductList2.txt";

        public void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("   Menyval för ACME & Co produktkatalog:\n");
            Console.WriteLine("1. Lägg till en produkt");
            Console.WriteLine("2. Visa hela katalogen");
            Console.WriteLine("3. Visa spec. produkt");
            Console.WriteLine("4. Ta bort produkt");
            Console.WriteLine("\n6. Läs in från fil");
            Console.WriteLine("7. Skriv till fil");
            Console.WriteLine("\n9. Avsluta programmet");
            Console.WriteLine("\n   Valfri övrig, för att visa menyvalen igen.");
        }

        public void GetMenuItem()
        {
            char MenuPick;
            do
            {
                MenuPick = (Console.ReadKey().KeyChar);
                Console.Clear();
                switch (MenuPick)
                {
                    case '1':
                        productHandler.Poke(almostDB);
                        break;
                    case '2':
                        listhandler.Print(almostDB);
                        break;
                    case '3':
                        productHandler.Peek(almostDB);
                        break;
                    case '4':
                        productHandler.Purge(almostDB);
                        break;
                    case '6':
                        almostDB = fileHandler.Retrieve(fileLocation);
                        break;
                    case '7':
                        fileHandler.Stowe(fileLocation, almostDB);
                        break;
                    default:
                        ShowMenu();
                        break;
                }

            } while (MenuPick != '9');

        }
    }
}
