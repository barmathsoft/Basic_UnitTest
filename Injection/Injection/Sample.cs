using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection
{
    public class Sample : ISample
    {
        Response response = new Response();
        bool valueForResponse;
        public string Add(Product product)
        {
            ValidationForPriceLessThanZero(product);
            ValidationForNameIsNull(product);
            ValidationForSucces(product);

            return response.Mesaage;
        }
    
        private void ValidationForPriceLessThanZero(Product product)
        {
            if (product.price < 0)
            {
                SetResponseProps(valueForResponse);
                Console.WriteLine($"The price must be greater than zero!");
            }
        }
        private void ValidationForNameIsNull(Product product)
        {
            if (string.IsNullOrEmpty(product.name))
            {
                SetResponseProps(valueForResponse);
                Console.WriteLine($"You must enter product name!");
            }
        }
   
        private void ValidationForSucces(Product product)
        {
            if (product.price > 0 && !string.IsNullOrEmpty(product.name))
            {
                valueForResponse = true;
                SetResponseProps(valueForResponse);
                Console.WriteLine($"The {product.name + product.price} has been added to list.");
            }
        }
        private void SetResponseProps(bool value)
        {
            if (!value)
            {
                response.IsSucces = value;
                response.Mesaage = "The product has not been add";
            }
            else
            {
                response.IsSucces = value;
                response.Mesaage = "The product has been added";
            }
        }
      
    }
}
