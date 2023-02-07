using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryExample1.Products
{
    internal class ConcreteProductTwo : IProduct
    {
        void IProduct.Operation()
        {
            Console.WriteLine("Делаем продукт по технологии 2");
        }
    }
}
