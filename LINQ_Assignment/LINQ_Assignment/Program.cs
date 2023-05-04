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
        public List<Product> seedata()
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
                //LINQ lINQ = new LINQ();
                Program lINQ = new Program();
                lINQ.seedata();
                Console.WriteLine("Product names from Product List where Price is between 20000 to 40000.");
                var productNames = lINQ.seedata().Where(p => p.Price >= 20000 && p.Price <= 40000)
                                  .Select(p => p.ProductName);
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                Console.WriteLine();

                Console.WriteLine("data from Product List where ProductName contains letter a.");
                var query = lINQ.seedata().Where(x => x.ProductName.Contains("a"));
                foreach (var data in query)
                {
                    Console.WriteLine($"{data.ProductID,-5} {data.ProductName,-10} {data.Brand,-10} {data.Quantity,-5} {data.Price}");
                }
                Console.WriteLine();

                Console.WriteLine("all data from Product List arranged in alphabetical order based on ProductName.");
                var query1 = lINQ.seedata().OrderBy(x => x.ProductName);
                foreach (var data in query1)
                {
                    Console.WriteLine($"{data.ProductID,-5} {data.ProductName,-10} {data.Brand,-10} {data.Quantity,-5} {data.Price}");
                }
                Console.WriteLine();

                var query2 = lINQ.seedata().Max(x => x.Price);
                Console.WriteLine("The highest Price from Product List: " + query2);
                Console.WriteLine();

                bool query3 = lINQ.seedata().Any(x => x.ProductID == "P003");
                Console.WriteLine("Product with ProductId P003 exists in Product List is: " + query3);
            }
        }
    }
}