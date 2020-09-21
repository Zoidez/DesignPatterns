using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuilder2 : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder2()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new Product();
        }
        public void AddPartA()
        {
            this._product.Add("PartA2");
        }
        public void AddPartB()
        {
            this._product.Add("PartB2");
        }
        public void AddPartC()
        {
            this._product.Add("PartC2");
        }
        public Product GetProduct()
        {
            Product product = this._product;
            this.Reset();
            return product;
        }
    }
}
