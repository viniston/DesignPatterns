using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public class ConcreteProductCollection : IProductCollection
    {
        private readonly List<Product> _products;

        public ConcreteProductCollection()
        {
            _products = new List<Product>();
        }

        public void Push(Product product)
        {
            _products.Add(product);
        }

        public IIterator CreateIterator()
        {
            return new ProductIterator(this);
        }

        public Product GetProduct(int index)
        {
            return _products[index];
        }

        public int ProductCount => _products.Count;
    }
}
