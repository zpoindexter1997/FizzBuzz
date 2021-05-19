using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var nbr = 1; nbr <= 30; nbr++)
            {
                if(nbr % 3 != 0 && nbr % 5 != 0)
                {
                    Console.WriteLine($"{nbr} produced neither");
                }
                var deter = nbr % 3 == 0 ? "FIZZ" : "BUZZ";
                Console.WriteLine($"{nbr} produced {deter}");
            }
        }
    }
}
