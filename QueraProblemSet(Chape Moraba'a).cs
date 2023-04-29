//https://quera.org/problemset/591/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quera
{
    class Program
    {
        static void Main(string[] args)
        {

            int Input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Input; i++)
                System.Console.Write('*');

            System.Console.WriteLine();

            for (int i = 0; i < Input - 2; i++)
            {
                System.Console.Write('*');
                for (int j = 0; j < Input-1; j++)
                {
                    System.Console.Write(" ");
                }
                System.Console.WriteLine('*');
            }

            for (int i = 0; i < Input; i++)
                System.Console.Write('*');



        }
    }
}
