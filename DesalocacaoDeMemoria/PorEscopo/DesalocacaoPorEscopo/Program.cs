namespace DesalocacaoPorEscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            if (x == 10)
            {
                int y = 20;
                x = y;
            }
            Console.WriteLine(x);

            //Ao terminar o escopo do if, a variável "y" será desalocada da memória.
        }
    }
}