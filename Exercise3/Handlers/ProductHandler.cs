using Exercise3.Interfaces;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Handlers
{
    public class ProductHandler : IProductHandler

    {
 
        public void Peek()
        {
            Console.Write("\t\t\t\t *** Not correctly implemented yet ***");
        }

        public void Poke(ProductModel TheProduct)
        {
            Console.WriteLine("Ny produkt:\n\n");
            Console.Write("Produktbenämning ? ");
            TheProduct.Name = Console.ReadLine();

            Console.Write("Kategori: ");
            TheProduct.Category = Console.ReadLine();
 
            Console.Write("Produktbeskrivning: ");
            TheProduct.Description = Console.ReadLine();

            Console.Write("Pris ex moms: ");
            TheProduct.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Antal i lager: ");
            TheProduct.Quantity = Convert.ToDecimal(Console.ReadLine());

            TheProduct.Id = ((Guid.NewGuid().ToString()).Split("-"))[0];

            Console.WriteLine($"\n\nProdukt förberedd: {TheProduct.Id} {TheProduct.Name}" );
            Console.WriteLine("____________________________________");

        }

        public void Purge()
        {
            Console.Write("\t\t\t\t *** Not correctly implemented yet ***");
        }
    }
}
