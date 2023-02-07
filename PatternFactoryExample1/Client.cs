using PatternFactoryExample1.ConcreteCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryExample1
{
    internal class Client
    {
        Creator product;

        private void SelectProduct(string param)
        {
            if (param == "1") product = new CreatorOne();
            if (param == "2") product = new CreatorTwo();
        }
        public void Main()
        {
            SelectProduct("2");
            product.MakeAction();

        }
    }
}
