namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            int x = 10;
            object obj1 = x;

            //Unboxing
            int y = 10;
            object obj2 = y;
            int z = (int) obj2;
        }
    }
}