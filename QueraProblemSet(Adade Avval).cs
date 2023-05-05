//https://quera.org/problemset/293/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quera
{
    class Program
    {
        static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int[] Output = new int[Num2];
            int Result = 0;
            int j = 0;

            for (int i = Num1; i < Num2+1; i++)
            {
                Result = Check_Prime(i);
                if (Result != 0)
                {
                    Output[j] = i;
                    j++;
                }

            }

            foreach (var item in Output)
            {
                if (item == 0)
                    continue;
                System.Console.WriteLine(item);
            }


        }
    }
}
