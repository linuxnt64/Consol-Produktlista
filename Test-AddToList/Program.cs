// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
start();

void start()
{

        List<Product> theList = new();
 
 
    do {
        Console.WriteLine("Ny produkt:\n\n");
        Product ProductItem = new();

        Console.Write("Produktbenämning ? ");
        ProductItem.Name = Console.ReadLine();

        Console.Write("Pris ex moms: ");
        ProductItem.Price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Antal i lager: ");
        ProductItem.Quantity = Convert.ToDecimal(Console.ReadLine());

        ProductItem.Id = ((Guid.NewGuid().ToString()).Split("-"))[0];

        Console.WriteLine($"\n\nProdukt förberedd: {ProductItem.Id} {ProductItem.Name}");


        theList.Add(ProductItem);

        foreach (Product piece in theList)
        {
            Console.WriteLine("Nu i listan: " + piece.Name);
        }
    } while (true);
}


public class Product
{
    public string Name { get; set; } = "";
    public string Id { get; set; } = "";
    public decimal Price { get; set; } = 0;
    public decimal Quantity { get; set; } = 0;
}




