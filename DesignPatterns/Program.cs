using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template  = DesignPatterns.Behavioral.TemplateMethod;
using strategy = DesignPatterns.Behavioral.StrategyPattern;
using facade = DesignPatterns.Structural.FacadePattern;
using decorator = DesignPatterns.Structural.DecoratorPattern;
using adapter = DesignPatterns.Structural.AdapterPattern;
using factory = DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a pattern to run");
                Console.WriteLine("1 - Template Method");
                Console.WriteLine("2 - Strategy Pattern");
                Console.WriteLine("3 - Facade Pattern");
                Console.WriteLine("4 - Decorator Pattern");
                Console.WriteLine("5 - Adapter Pattern");
                Console.WriteLine("6 - Factory Method");
                var lineRead = Console.ReadLine();

                if (lineRead == "1")
                {
                    Console.WriteLine("In Template pattern, an abstract class defined the template method and this method includes the steps which are implemented by the subclasses.");
                    //These are subclasses which inherits the AbstractClass and override the abstract class operations
                    template.Class1 concreteClass1 = new template.Class1();
                    template.Class2 concreteClass2 = new template.Class2();

                    concreteClass1.TemplateMethod();
                    concreteClass2.TemplateMethod();
                }
                if (lineRead == "2")
                {
                    Console.WriteLine("In Strategy pattern, this pattern involves the removal of an algorithm from its host class and putting it in a separate class");
                    //These are classes which implement the strategy Interface
                    strategy.IStrategy concreteClass1 = new strategy.Class1();
                    strategy.IStrategy concreteClass2 = new strategy.Class2();
 
                    Console.WriteLine(concreteClass1.Algorithm());
                    Console.WriteLine(concreteClass2.Algorithm());
                }
                if (lineRead == "3")
                {
                    Console.WriteLine("Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system.");
                    facade.Facade facade = new facade.Facade();

                    facade.Operation1();
                    facade.Operation2();
                }
                if (lineRead == "4")
                {
                    Console.WriteLine("Decorator pattern is used to add new functionality to an existing object without changing its structure.");
                    decorator.Component component = new decorator.Component();

                    component.Operation();

                    // Override the the original operation but keep the component the same
                    decorator.ConcreteDecorator concreteDecorator = new decorator.ConcreteDecorator(component);
                    concreteDecorator.Operation();

                }
                if (lineRead == "5")
                {
                     Console.WriteLine("Adapter pattern acts as a bridge between two incompatible interfaces. This pattern involves a single class called adapter which is responsible for communication between two independent or incompatible interfaces.");
                     adapter.ITarget Itarget = new adapter.Adapter();
                     adapter.Client client = new adapter.Client(Itarget);
                     client.MakeRequest();
                }
                if (lineRead == "6")
                {
                    Console.WriteLine("In Factory pattern, we create object without exposing the creation logic.");

                    factory.Creator creator = new factory.ConcreteCreator();
                    factory.IProduct product = creator.FactoryMethod("A");
                    Console.WriteLine(product.name);
                }
                else
                    Console.WriteLine("No pattern found");

            }
        }
    }
}
