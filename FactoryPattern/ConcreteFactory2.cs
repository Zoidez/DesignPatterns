using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConcreteFactory2 : Factory
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProduct2();
        }
    }
}
