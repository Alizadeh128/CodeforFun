//https://quera.org/problemset/3414/

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

            string Input = Console.ReadLine();
            string[] ArrInput = Input.Split(' ').Select(a => a.Trim()).ToArray();

            if (ArrInput[1] == ArrInput[3])
                System.Console.WriteLine("Horizontal");
            else if (ArrInput[0] == ArrInput[2])
                System.Console.WriteLine("Vertical");
            else
                System.Console.WriteLine("Try again");

        }
    }
}
