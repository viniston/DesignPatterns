namespace DesignPatterns.Iterator
{
    public class ProductIterator : IIterator
    {
        private int _index;
        private readonly ConcreteProductCollection _productCollection;

        public ProductIterator(ConcreteProductCollection productCollection)
        {
            _productCollection = productCollection;
        }

        public bool HasNext()
        {
            return _index < _productCollection.ProductCount;
        }

        public void Next()
        {
            _index++;
        }

        public Product Current()
        {
            return _productCollection.GetProduct(_index);
        }
    }
}
