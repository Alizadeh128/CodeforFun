//https://quera.org/problemset/3430/

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
            int Temp = 1;
            int Rem = 0;

            System.Console.WriteLine(Input);

            for (int i = 0; i < Input.Length; i++)
            {
                try
                {
                    for (int j = -1; j < Temp; j++)
                    {
                        System.Console.Write(Input[Temp]);
                    }
                    Temp++;

                    for (Rem = Temp; Rem < Input.Length; Rem++)
                    {
                        System.Console.Write(Input[Rem]);
                    }
                    System.Console.WriteLine();
                }
                catch
                {
                    continue;
                }


            }

        }
    }
}
