using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component) { }

        public override void Operation()
        {
            //base operation can be called un touched
            base.Operation();
            //and we can add additional functionality
            Console.WriteLine("Override Decorator Operation");
        }
    }
}
