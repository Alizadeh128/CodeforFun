//https://quera.org/problemset/3406/1

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
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int  n1=Num1,n2=Num2 ,reverse1 = 0,reverse2 = 0, rem;

            while (n1 != 0)
            {
                rem = n1 % 10;
                reverse1 = reverse1 * 10 + rem;
                n1 /= 10;
            }

            while (n2 != 0)
            {
                rem = n2 % 10;
                reverse2 = reverse2 * 10 + rem;
                n2 /= 10;
            }

            if(reverse1 > reverse2)
            System.Console.WriteLine(Num2+" < "+Num1);
            if(reverse1 < reverse2)
            System.Console.WriteLine(Num1+" < "+Num2);
            if(reverse1 == reverse2)
            System.Console.WriteLine(Num2+" = "+Num1);
        }
    }
}
