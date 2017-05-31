using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Product1 : IProduct
    {
        public string name { get; set; }

        public Product1()
        {
            name = "Product1";
        }
    }
}
