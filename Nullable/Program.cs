namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            //Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);

            if(x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else 
            {
                Console.WriteLine("X is Null");
            }

            //Operador de coalescência nula

            int a = x ?? 5;
            int b = y ?? 5;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");

        }
    }
}