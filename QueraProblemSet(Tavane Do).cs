//https://quera.org/problemset/616/

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
          
          Double Input = Convert.ToDouble(Console.ReadLine());
          Double Output = 0;
          int i = 1;

          while(Input >= Output){

            Output = Math.Pow(2, i);
            i++;
          }

          System.Console.WriteLine(Output);

        }
    }
}
