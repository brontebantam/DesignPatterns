using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FacadePattern
{
    public class SubSystemA
    {
        public string OperationA1()
        {
            return "Subsystem A, Method A1\n";
        }
        public string OperationA2()
        {
            return "Subsystem A, Method A2\n";
        }
    }
}
