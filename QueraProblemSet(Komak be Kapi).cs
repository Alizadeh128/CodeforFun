//https://quera.org/problemset/8838/

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
            string[] Input = Console.ReadLine().Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int Temp = Convert.ToInt32(Input[0]);

            for (int i = 0; i < Temp; i++)
                System.Console.Write("copy of ");
            
            System.Console.Write(Input[1]);
        }
    }
}
