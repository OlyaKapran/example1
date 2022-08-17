using System;

namespace example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1, 10 ); // 1,2,3,4,...,9
            Console.WriteLine(numberA);
            int numberB = new Random().Next(1, 10);
            Console.WriteLine(numberB);
            int result = numberB + numberA ;
            Console.WriteLine(result);

        }
    }
}
