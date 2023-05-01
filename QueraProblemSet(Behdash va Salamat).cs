//https://quera.org/problemset/51865/

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
            int Grade = Convert.ToInt32(Console.ReadLine());
            int Days = Convert.ToInt32(Console.ReadLine());
            int NewGrade = Grade - Days;

            if (Days == 7)
                System.Console.WriteLine(Grade);
            else if (Days == 0)
                System.Console.WriteLine("20");
            else if (NewGrade < 0)
                System.Console.WriteLine("0");
            else
                System.Console.WriteLine(NewGrade);




        }
    }
}
