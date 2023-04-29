//https://quera.org/problemset/3409/

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

            for (int i = 1; i < Input+1; i++)
            {
              for (int j = 1; j < Input+1; j++)
              {
                System.Console.Write(j*i+" ");
              }
               System.Console.WriteLine();
            }


        }
    }
}
