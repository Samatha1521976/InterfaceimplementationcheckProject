using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceimplementationcheckProject
{
    // Verification class
    internal class Verification
    {
       
        
            public bool CheckIfInterfaceImplemented(string interfaceName)
            {
                Type type = typeof(Sample);
                return type.GetInterfaces().Any(i => i.Name == interfaceName);
            }

            public bool CheckIfConstructorExists(string constructorName)
            {
                Type type = typeof(Sample);
                return type.GetConstructors().Any(c => c.ToString() == constructorName);
            }

            public bool CheckIfMethodExists(string methodName)
            {
                Type type = typeof(Sample);
                return type.GetMethods().Any(m => m.Name == methodName);
            }
        
    }
}
