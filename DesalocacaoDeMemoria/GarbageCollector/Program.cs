namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("TV", 500.0, 2);
            Product p2 = new Product("Notebook", 300.0, 1);

            p1 = p2;

            Console.WriteLine(p1);
        }
    }
}