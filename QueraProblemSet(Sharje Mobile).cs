//https://quera.org/problemset/17244/

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
            int Output = 0;

            for (int i = 0; i < Input+1; i++)
                Output += i;

                System.Console.WriteLine(Output);
            
            
        }
    }
}
