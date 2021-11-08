namespace DesignPatterns.Iterator
{
    public class Product
    {
        private int Id { get; }
        private string Name { get; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Product Id={Id}, Product Name= {Name}";
        }
    }
}
