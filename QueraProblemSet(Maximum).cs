//https://quera.org/problemset/588/

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
            string[] Input = Console.ReadLine().Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int[] myInts = Input.Select(int.Parse).ToArray();
            int maxValue = myInts.Max();
            System.Console.WriteLine(maxValue);
        }
    }
}
