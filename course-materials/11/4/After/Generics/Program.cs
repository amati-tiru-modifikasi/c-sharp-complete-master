using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order<string>(); // KO
            var order2 = new Order<int>(); // KO
            var order3 = new Order<object>(); // KO
            var order4 = new Order<Product>(); // OK
        }
    }
}
