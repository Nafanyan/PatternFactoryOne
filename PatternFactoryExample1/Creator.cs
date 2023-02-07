using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryExample1
{
    internal abstract class Creator
    {
        protected IProduct product;
        abstract protected IProduct GetProduct();

        public void MakeAction()
        {
            product = GetProduct();
            product.Operation();
        }

    }
}
