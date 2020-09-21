using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IAbstractProductB
    {
        string SomeFunction();

        string AnotherFunction(IAbstractProductA collaborator); //IAbstractProductB demonstrates how different products of diccerent types and with the same variant (1, 2) can collaborate. AbstractFactory makes sure that all products it creates are of the same vaiant.
    }
}
