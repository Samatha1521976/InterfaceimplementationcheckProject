using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceimplementationcheckProject
{
    // Sample class implementing InterfaceA

    internal class Sample : InterfaceA
    {
       
            public void InterfaceMethod()
            {
                Console.WriteLine("Printed from Sample class");
            }
        
    }
}
