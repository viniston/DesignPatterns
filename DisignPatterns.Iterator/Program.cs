using System;

namespace DesignPatterns.Iterator
{
    class Program
    {
        static void Main()
        {
            var productCollection = new ProductCollection();
            productCollection.Push(new Product(1, "Mobile Phone"));
            productCollection.Push(new Product(2, "Laptop"));

            var productIterator = productCollection.CreateIterator();
            while (productIterator.HasNext())
            {
                Console.WriteLine(productIterator.Current());
                productIterator.Next();

            }

            Console.ReadLine();
        }
    }
}
