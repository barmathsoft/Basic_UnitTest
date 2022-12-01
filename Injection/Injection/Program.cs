using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.price = -10;

            Client client = new Client(new Sample());
            client.Add(product);

            Console.ReadLine();
        }
    }
}
