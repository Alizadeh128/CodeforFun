//https://quera.org/problemset/617/

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
            int Output = Input.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
            
            if(Input == Output)
            System.Console.WriteLine("YES");
            else
            System.Console.WriteLine("NO");
        }
    }
}
