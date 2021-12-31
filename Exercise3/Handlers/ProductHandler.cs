using Exercise3.Interfaces;
using Exercise3.Models;

namespace Exercise3.Handlers
{
    public class ProductHandler : IProductHandler
    {
        public void Peek(List<ProductModel> TheList)
        {
            ProductModel searchObject = new();
            Console.WriteLine("Visa produktinfo:\n\n");
            Console.Write("Skriv produktID :  ");
            string searchTerm = Console.ReadLine();
            searchObject = (ListHandler.FindItem(TheList, searchTerm));

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

        public void Poke(ProductModel theProduct)
        {
            Console.WriteLine("Ny produkt:\n\n");
            Console.Write("Produktbenämning ? ");
            theProduct.Name = Console.ReadLine();

            Console.Write("Kategori: ");
            theProduct.Category = Console.ReadLine();

            Console.Write("Produktbeskrivning: ");
            theProduct.Description = Console.ReadLine();

            Console.Write("Pris ex moms: ");
            theProduct.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Antal i lager: ");
            theProduct.Quantity = Convert.ToDecimal(Console.ReadLine());

            theProduct.Id = ((Guid.NewGuid().ToString()).Split("-"))[0];

            Console.WriteLine($"\n\nProdukt förberedd: {theProduct.Id} {theProduct.Name}");
            Console.WriteLine("____________________________________");

        }

        public void Purge(List<ProductModel> TheList)
        {
            Console.WriteLine("%%%%%%%%%% Ta bort produkt från listan: %%%%%%%%%%\n\n");
            Console.Write("Skriv produktID :  ");
            string searchTerm = Console.ReadLine();
            bool res = ListHandler.Delete(TheList, searchTerm);
            if (!res) Console.WriteLine($"%%%%%%%%%% Något är fel, kunde inte radera { searchTerm} %%%%%%%%%% ");
            else Console.WriteLine($"ProduktID : {searchTerm} är nu raderad!");
        }
    }
}