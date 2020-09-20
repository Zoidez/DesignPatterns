using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Client
    {
        public void Main()
        {
            IProduct product = new ConcreteFactory1().CreateProduct(); // The product is of the parent type and thus can hold any child type object. Here it is ConcreteProduct1.
            Debug.WriteLine("ConcreteCreator1:" + product.Operation());

            product = new ConcreteFactory2().CreateProduct(); // And here it is ConcreteProduct2
            Debug.WriteLine("ConcreteCreator2:" + product.Operation());
        }
    }
}
