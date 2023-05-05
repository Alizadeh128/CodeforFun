//https://quera.org/problemset/3408/

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
            int Nokhodi = Convert.ToInt32(Console.ReadLine());
            string[] Input = Console.ReadLine().Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();

            for (int i = Input.Length-1; i > -1; i--)
             System.Console.Write(Input[i]+" ");
        }
    }
}
