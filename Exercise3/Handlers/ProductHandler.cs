using Exercise3.Interfaces;
using Exercise3.Models;

namespace Exercise3.Handlers
{
    public class ProductHandler : IProductHandler
    {
        ListHandler lh = new();
        public void Peek(List<ProductModel> TheList)
        {
            ProductModel searchObject = new();
            Console.WriteLine("Visa produktinfo:\n\n");
            Console.Write("Skriv produktID :  ");
            string searchTerm = Console.ReadLine();
            searchObject = lh.FindItem(TheList, searchTerm);

            if (searchObject != null)
            {
                Console.WriteLine("\n\nProduktinformation:\n" +
                                      "-------------------\n");
                Console.WriteLine($"{searchObject.Name}     {searchObject.Category}");

                Console.WriteLine(searchObject.Description);

                Console.WriteLine($"Pris : {searchObject.Price}    I lager : {searchObject.Quantity}");
            }
            else { Console.WriteLine("### Ingen produkt med detta ID finns ###"); }
        }

        public void Poke(List<ProductModel> TheList)
        {
            ProductModel productItem = new();
            string temp = "";

            Console.WriteLine("Ny produkt:\n\n");
            Console.Write("Produktbenämning ? ");
            temp = Console.ReadLine();
            productItem.Name = temp != "" ? temp : "%%%%% Ogiltligt produktnamn %%%%%";

            Console.Write("Kategori: ");
            productItem.Category = Console.ReadLine();

            Console.Write("Produktbeskrivning: ");
            productItem.Description = Console.ReadLine();

            Console.Write("Pris ex moms: ");
            temp = Console.ReadLine();
            productItem.Price = Convert.ToDecimal(temp != "" ? temp : "0");

            Console.Write("Antal i lager: ");
            temp = Console.ReadLine();
            productItem.Quantity = Convert.ToDecimal(temp != "" ? temp : "0");

            productItem.Id = ((Guid.NewGuid().ToString()).Split("-"))[0];

            Console.WriteLine($"\n\nProdukt förberedd: {productItem.Id} {productItem.Name}");

            if (productItem.Name != "%%%%% Ogiltligt produktnamn %%%%%" && productItem.Price > 0 && productItem.Quantity > 0)
            {
                Console.WriteLine("____________________________________");
                lh.Write(productItem, TheList);
            }
            else { Console.WriteLine(productItem.Id + "kunde INTE skrivas till listan"); }
        }

        public void Purge(List<ProductModel> TheList)
        {
            Console.WriteLine("%%%%%%%%%% Ta bort produkt från listan: %%%%%%%%%%\n\n");
            Console.Write("Skriv produktID :  ");
            string searchTerm = Console.ReadLine();
            bool res = lh.Delete(TheList, searchTerm);
            if (!res) Console.WriteLine($"%%%%%%%%%% Något är fel, kunde inte radera { searchTerm} %%%%%%%%%% ");
            else Console.WriteLine($"ProduktID : {searchTerm} är nu raderad!");
        }
    }
}