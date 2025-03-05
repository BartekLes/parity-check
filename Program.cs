using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parity_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumber();

            int GetNumber()
            {
                Console.WriteLine("Podaj liczbę.");
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out int input))
                    {
                        Console.WriteLine("Podana wartość nie jest liczbą. Spróbuj ponownie");
                        continue;
                    }

                    return input;
                }
            }

        }
    }
}
