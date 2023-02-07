using PatternFactoryExample1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryExample1.ConcreteCreator
{
    internal class CreatorTwo : Creator
    {
        protected override IProduct GetProduct()
        {
            return new ConcreteProductTwo();
        }
    }
}
