namespace DesignPatterns.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        void Next();
        Product Current();
    }
}
