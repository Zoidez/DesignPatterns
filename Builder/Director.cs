using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { this._builder = value; }
            get { return this._builder; }
        }

        public void BuildMinimalProduct()
        {
            this._builder.AddPartA();
        }
        public void BuildMaximalProduct()
        {
            this._builder.AddPartA();
            this._builder.AddPartB();
            this._builder.AddPartC();
        }
    }
}
