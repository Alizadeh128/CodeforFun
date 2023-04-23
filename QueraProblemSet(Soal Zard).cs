//https://quera.org/problemset/3537/

// input:
// 2
// output:
// Woow!

// input:
// 3
// output:
// Wooow!

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
        string Empty = "";

        for (int i = 0; i < Input; i++)
        {
          Empty = "o" + Empty;
        }
        System.Console.WriteLine("W"+Empty+"w!");

    }
  }
}
