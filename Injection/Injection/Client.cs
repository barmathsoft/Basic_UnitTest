using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection
{

    public class Client
    {
        ISample _sample;
        public Client(ISample sample)
        {
            this._sample = sample;
        }
    
        public void Add(Product product)
        {
            _sample.Add(product);
        }
    }
}
