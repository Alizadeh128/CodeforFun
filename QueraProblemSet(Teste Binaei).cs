//https://quera.org/problemset/2659

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
            int Num = Convert.ToInt32(Console.ReadLine());
            string Input = Console.ReadLine();
            string OInput = Console.ReadLine();
            int Error = 0;

            for (int i = 0; i < Num; i++)
            {
                if(Input[i] != OInput[i])
                Error++;
            }

            System.Console.WriteLine(Error);
            
        }
    }
}
