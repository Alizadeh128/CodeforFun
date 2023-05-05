//https://quera.org/problemset/17675/

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
            Input++;
            int[] Fib = new int[Input];
            Fib[0] = 0;
            int a = 0, b = 1, c = 0, flag = 0;
            for (int i = 1; i < Input; i++)
            {
                c = a + b;
                Fib[i] = c;
                a = b;
                b = c;
            }

            for (int i = 1; i < Input; i++)
            {
                for (int j = 1; j < Input; j++)
                {
                    if(i == Fib[j])
                    flag++;
                }

                if(flag == 1)
                System.Console.Write('+');
                else
                System.Console.Write('-');
                flag = 0;
            }

           

        }
    }
}
