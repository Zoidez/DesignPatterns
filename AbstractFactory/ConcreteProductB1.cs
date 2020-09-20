using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConcreteProductB1 : IAbstractProductB
    {
        public string SomeFunction()
        {
            return "ConcreteProductB1";
        }

        public string AnotherFunction(IAbstractProductA collaborator)
        {
            return "ConcreteProductB1 collaborates with " + collaborator.SomeFunction();
        }
    }
}
