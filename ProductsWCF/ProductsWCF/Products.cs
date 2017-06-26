using System.Collections.Generic;

namespace ProductsWCF
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
    }
    internal partial class Products
    {
        private static readonly Products _instance = new Products();

        private Products() { }

        public static Products Instance
        {
            get{ return _instance; }
        }

        public List<Product> ProductList
        {
            get { return products; }
        }

        static List<Product> products = new List<Product> {
                new Product{ProductId=1, Name="Soap", Qty=3, Price=23.4},
                new Product{ProductId=2, Name="Bag", Qty=3, Price=500},
                new Product{ProductId=3, Name="Books", Qty=10, Price=300},
                new Product{ProductId=4, Name="Deo", Qty=5, Price=120}
        }; 
    }
}