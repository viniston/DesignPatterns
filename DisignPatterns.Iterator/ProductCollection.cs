using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Iterator
{
    public class ProductCollection
    {
        private readonly List<Product> _products;

        public ProductCollection()
        {
            _products = new List<Product>();
        }

        public void Push(Product product)
        {
            _products.Add(product);
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator
        {
            private int _index;
            private readonly ProductCollection _productCollection;

            public ListIterator(ProductCollection productCollection)
            {
                _productCollection = productCollection;
            }

            public bool HasNext()
            {
                return _index < _productCollection._products.Count;
            }

            public void Next()
            {
                _index++;
            }

            public Product Current()
            {
                return _productCollection._products.ElementAt(_index);
            }
        }

    }
}
