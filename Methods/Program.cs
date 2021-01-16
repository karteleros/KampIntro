using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double cost = 15;
            string info = "Amasya Elmasi";

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Cost = 15;
            product1.Info = "Amasya Elmasi";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Cost = 80;
            product2.Info = "Kelek";

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + "\n" + product.Cost + "\n" + product.Info );
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------------Methods------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product2);
            sepetManager.Add(product1);

            sepetManager.Add2("Armut", "Yeşil Armut", 12, 2);
        }

    }
}
 