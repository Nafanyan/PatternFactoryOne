using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryExample1.Products
{
    internal class ConcreteProductOne : IProduct
    {
        void IProduct.Operation()
        {
            Console.WriteLine("Делаем продукт по технологии 1");
        }
    }
}
