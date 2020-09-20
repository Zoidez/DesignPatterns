using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
   abstract class Factory
    {
        public abstract IProduct CreateProduct();

        public string SomeOperation()
        {
            IProduct product = CreateProduct();
            string result = "IFactory: SomeOperation(); invoked " + product.Operation();
            return result;
        }
    }
}
