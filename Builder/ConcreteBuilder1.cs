using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuilder1 : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder1()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new Product();
        }

        // All production steps work with the same product instance.
        public void AddPartA()
        {
            this._product.Add("PartA1");
        }
        public void AddPartB()
        {
            this._product.Add("PartB1");
        }
        public void AddPartC()
        {
            this._product.Add("PartC1");
        }

        public Product GetProduct()
        {
            Product product = this._product;
            this.Reset();
            return product;
        }
    }
}
