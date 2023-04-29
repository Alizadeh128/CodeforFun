//https://quera.org/problemset/9774/

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

            string Input = Console.ReadLine();
            string[] InputStringArray = new string[Input.Length];
            int[] InputIntArray = new int[Input.Length];

            for (int i = 0; i < Input.Length; i++)
            {
             InputStringArray[i] = Input[i] + "";
             InputIntArray[i] = Convert.ToInt32(InputStringArray[i]);
            }

            for (int i = 0; i < Input.Length; i++)
            {
              System.Console.Write(InputIntArray[i]+": ");

              for (int j = 0; j < InputIntArray[i]; j++)
              {
                System.Console.Write(InputIntArray[i]);
              }
              System.Console.WriteLine();
            }


        }
    }
}
