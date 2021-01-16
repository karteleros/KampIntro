using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " Sepete Eklendi... Tebrikler");        
        }
        public void Add2(string productName, string productInfo, double cost, int stok )
        {
            Console.WriteLine(productName + " Sepete Eklendi... Tebrikler");
        }
    }

    
}
 