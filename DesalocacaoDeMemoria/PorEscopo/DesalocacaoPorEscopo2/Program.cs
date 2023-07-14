namespace DesalocacaoPorEscopo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = Method();
            Console.WriteLine(p);
        }
        public static Product Method ()
        {
            Product product = new Product("TV", 50.0, 2);
            return product;
        }
    }
}