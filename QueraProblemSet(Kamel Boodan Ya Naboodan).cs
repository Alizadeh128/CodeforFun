//https://quera.org/problemset/282

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
            String Output= "";

            for (int i = 1; i < Input; i++)
                {
                    if (Input % i == 0)
                    Output += i + ",";       
                }

            string[] SArray = Output.Split(',');
            int[] ints = new int[SArray.Length];

            for (int i = 0; i < SArray.Length-1; i++)
            {
                ints[i] = Convert.ToInt32(SArray[i]);
            }
            int Sum = ints.Sum();
            
            if(Sum == Input)
            System.Console.WriteLine("YES");
            else
            System.Console.WriteLine("NO");

            // foreach (var item in ints)
            // {
            //     System.Console.WriteLine(item);
            // }

        }
    }
}
