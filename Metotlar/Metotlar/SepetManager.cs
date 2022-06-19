using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Addsepet(Product product)
        {
            Console.WriteLine("Sepete eklendi " + product.Explanation);
        }
        
    }
}
