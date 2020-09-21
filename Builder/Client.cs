using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Client
    {
        public void Main()
        {
            Director director = new Director();
            ConcreteBuilder1 builder1 = new ConcreteBuilder1();
            ConcreteBuilder2 builder2 = new ConcreteBuilder2();
            director.Builder = builder1;

            Debug.WriteLine("Min Product by ConcreteBuilder1: ");
            director.BuildMinimalProduct();
            Debug.WriteLine(director.Builder.GetProduct());
            Debug.WriteLine("Max Product by ConcreteBuilder1: ");
            director.BuildMaximalProduct();
            Debug.WriteLine(director.Builder.GetProduct());

            director.Builder = builder2;
            Debug.WriteLine("Min Product by ConcreteBuilder2: ");
            director.BuildMinimalProduct();
            Debug.WriteLine(director.Builder.GetProduct());
            Debug.WriteLine("Max Product by ConcreteBuilder2: ");
            director.BuildMaximalProduct();
            Debug.WriteLine(director.Builder.GetProduct());
        }
    }
}
