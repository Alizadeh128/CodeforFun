//https://quera.org/problemset/3538/

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
            int Num1 = Convert.ToInt32(Console.ReadLine());
            string[] Input1 = Console.ReadLine().Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int Num2 = Convert.ToInt32(Console.ReadLine());
            string[] Input2 = Console.ReadLine().Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int Num3 = Convert.ToInt32(Console.ReadLine());
            string[] Input3 = Console.ReadLine().Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();

            string[] FinalArray = Input1.Concat(Input2).Concat(Input3).Distinct().ToArray();

            int Output = 7 - FinalArray.Length;

            System.Console.WriteLine(Output);

        }
    }
}
