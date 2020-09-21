using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new Product();
        }
        public void BuildPartA()
        {
            this._product.Add("Part1");
        }
        public void BuildPartB()
        {
            this._product.Add("Part2");
        }
        public void BuildPartC()
        {
            this._product.Add("PartC");
        }
    }
}
