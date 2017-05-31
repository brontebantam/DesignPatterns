using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod(string type);
    }
}
