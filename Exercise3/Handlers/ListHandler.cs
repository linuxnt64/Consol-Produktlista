using Exercise3.Interfaces;
using Exercise3.Models;

namespace Exercise3.Handlers
{
    public class ListHandler : IListHandler
    {

        public void Write(ProductModel productItem, List<ProductModel> TheList)
        {
            TheList.Add(productItem);
            Console.WriteLine($"item {productItem.Id} {productItem.Name} added to list");
        }

        public void Print(List<ProductModel> TheList)
        {
            Console.WriteLine("Produkter i listan:\n\n");
            Console.WriteLine("Id_______Benämning____Första 35 tkn i beskrivningen\n");
            foreach (var item in TheList)
            {
                Console.WriteLine($"{item.Id} {item.Name}     {item.Description.Substring(0,35)}\n");
            }
        }

        public static ProductModel FindItem(List<ProductModel> TheList, string term)
        {
            foreach (ProductModel findItem in TheList)
            {
                if (findItem.Id == term) { return findItem; }
            }
            return null;
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

