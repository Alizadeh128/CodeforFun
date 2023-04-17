//https://quera.org/problemset/589/

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
        int Factorial = 1;

        for(int i = 1; i < Num+1 ; i++)
        Factorial *= i;

        System.Console.WriteLine(Factorial);
    }
  }
}
