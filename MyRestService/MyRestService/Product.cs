using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyRestService
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }

    public class Products
    {
        private static Products _instance = new Products();

        private Products() { }

        public static Products Instance
        {
            get { return _instance; }
        }

        public List<Product> ProductList
        {
            get { return _products; }
        }

        private List<Product> _products = new List<Product>()
        {
            new Product{ ProductID=1, Name="Soap", CategoryName="A", Price= 67 },
            new Product{ ProductID=1, Name="Bat", CategoryName="A", Price= 200 },
            new Product{ ProductID=1, Name="Oil", CategoryName="A", Price= 76 },
            new Product{ ProductID=1, Name="Bag", CategoryName="A", Price=600 }
        };
    }
}