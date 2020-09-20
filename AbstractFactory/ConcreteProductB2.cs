using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConcreteProductB2 : IAbstractProductB
    {
        public string SomeFunction()
        {
            return "ConcreteProductB2";
        }

        public string AnotherFunction(IAbstractProductA collaborator)
        {
            return "ConcreteProductB2 collaborates with " + collaborator.SomeFunction();
        }
    }
}
