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
            Console.WriteLine(number);

            int GetNumber()
            {
                Console.WriteLine("Podaj liczbę");
                var gettedNumber = int.Parse(Console.ReadLine());
                return gettedNumber;
            }

        }
    }
}
