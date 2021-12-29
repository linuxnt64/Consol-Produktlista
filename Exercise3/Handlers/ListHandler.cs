using Exercise3.Interfaces;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Handlers
{
    public class ListHandler
    {

        public static ProductModel FindItem(List<ProductModel> TheList, string term)
        {
            //           Console.Write("\t\t\t\t *** Not correctly implemented yet ***");

            foreach (ProductModel findItem in TheList)
            {
                if (findItem.Id == term) { return findItem; }
            }
            return null;
        }

        public void Print(ProductModel productItem, List<ProductModel> TheList)
        {
            Console.WriteLine("produkter i listan:\n\n");
            foreach (var item in TheList)
            {
                Console.WriteLine($"{item.Id} {item.Name} \n");
            }
        }

        public static void Retrieve(string index)
        {
            throw new NotImplementedException();
        }

        public void Write(ProductModel productItem, List<ProductModel> TheList)
        {
            TheList.Add(productItem);
            Console.WriteLine($"item {productItem.Id} {productItem.Name} added to list");
        }

        public static bool Delete(List<ProductModel> TheList, string term)
        {
            ProductModel foundItem = new();
            foreach (ProductModel Item in TheList)
            {
                if (Item.Id == term)
                {
                    foundItem = Item;
                    break;
                }

            }
            return TheList.Remove(foundItem);
        }
    }
}

