using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new Product1();
                case "B": return new Product2();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
