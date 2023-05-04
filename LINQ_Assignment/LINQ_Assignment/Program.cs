namespace LINQ_Assignment
{
    class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }


    internal class Program
    {
        List<Product> products;
        public List<Product> SeedData()
        {

            products = new List<Product>()
            {
                new Product() { ProductID = "P001", ProductName="Laptop",Brand="Dell",Quantity=5, Price=35000 },
                new Product() { ProductID = "P002", ProductName="Camera",Brand="Canon",Quantity=8, Price=28500 },
                new Product() { ProductID = "P003", ProductName="Tablet",Brand="Lenova",Quantity=4, Price=15000 },
                new Product() { ProductID = "P004", ProductName="Mobile",Brand="Apple",Quantity=9, Price=65000 },
                new Product() { ProductID = "P005", ProductName="Earphones",Brand="Boat",Quantity=2, Price=1500 }
            };
            return products;
        }

        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Program linq = new Program();
                linq.SeedData();

                var productsBetween20000And40000 = linq.SeedData().Where(p => p.Price >= 20000 && p.Price <= 40000)
                                                            .Select(p => p.ProductName);

                Console.WriteLine("Product names where Price is between 20000 to 40000:");
                foreach (var name in productsBetween20000And40000)
                {
                    Console.WriteLine(name);
                }

                var productsWithLetterA = linq.SeedData().Where(p => p.ProductName.Contains("a"));

                Console.WriteLine("\nProducts where ProductName contains letter a:");
                foreach (var product in productsWithLetterA)
                {
                    Console.WriteLine($" {product.ProductID} {product.ProductName} {product.Brand} {product.Quantity} {product.Price}");
                }

                var productsInAlphabeticalOrder = linq.SeedData().OrderBy(p => p.ProductName);

                Console.WriteLine("\nAll products arranged in alphabetical order based on ProductName:");
                foreach (var product in productsInAlphabeticalOrder)
                {
                    Console.WriteLine($" {product.ProductID} {product.ProductName} {product.Brand} {product.Quantity} {product.Price}");
                }

                var highestPrice = linq.SeedData().Max(p => p.Price);

                Console.WriteLine("\nHighest Price from Product List: " + highestPrice);

                bool productWithIdP003Exists = linq.SeedData().Any(p => p.ProductID == "P003");

                Console.WriteLine("\nProduct with ProductId P003 exists in Product List: " + productWithIdP003Exists);
            }
        }
    }
}