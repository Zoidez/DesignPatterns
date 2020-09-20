using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Creating a set using Factory1");
            ManufactureSet(new ConcreteFactory1());
        }

        public void ManufactureSet(IAbstractFactory factory)
        {
            IAbstractProductA productA = factory.CreateProductA();
            IAbstractProductB productB = factory.CreateProductB();
            Debug.WriteLine("Created: " + productA.SomeFunction() + ", " + productB.SomeFunction());
            Debug.WriteLine("Tested: " + productB.AnotherFunction(productA));
        }
    }
}
