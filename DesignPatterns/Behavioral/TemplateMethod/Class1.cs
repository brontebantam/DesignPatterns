using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Class1 : AbstractClass
    {
        public override void Step1()
        {
            Console.WriteLine("Class1, Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Class1, Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Class1, Step 3");
        }
    }
}
