//https://quera.org/problemset/3405/

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
          
          int[] Input = new int[1000];
          int i;

          for (i = 0; i <1000 ; i++)
          {
            Input[i] = Convert.ToInt32(Console.ReadLine());
            if(Input[i] == 0)
                break;
          }
          
          for (int j = i-1; j >= 0; j--)
          {
            System.Console.WriteLine(Input[j]);
          }

        }
    }
}
