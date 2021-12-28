using Exercise3.Interfaces;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Handlers
{
    public class ListHandler : IListHandler
    {

        public int FindItem(string _searcher)
        {
            Console.Write("\t\t\t\t *** Not correctly implemented yet ***");
            return 1;
        }

        public void Print(ProductModel productItem, List<ProductModel> TheList)
        {
            Console.WriteLine("\t\t\t\t *** Maybe not correctly implemented yet ***");
            Console.WriteLine("produkter i listan:\n\n");
            foreach(var item in TheList)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Quantity} á {item.Price} kr (st/kg/liter)  {item.Description}\n");
            }
        }

        public void Retrieve(int index)
        {
            throw new NotImplementedException();
        }

        public void Write(ProductModel productItem, List<ProductModel> TheList)
        {
            TheList.Add(productItem);
            Console.WriteLine($"item {productItem.Id} {productItem.Name} added to list");
        }

        public void Delete(int _id)
        {
            Console.Write("\t\t\t\t *** Not correctly implemented yet ***");
        }
    }
}
