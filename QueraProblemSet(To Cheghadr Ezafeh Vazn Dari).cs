//https://quera.org/problemset/3404/

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
            float Weight = Convert.ToSingle(Console.ReadLine());
            float Height = Convert.ToSingle(Console.ReadLine());

            float BMI = Weight / (Height * Height);
            string Output = BMI.ToString("0.00");

            if (BMI < 18.5)
            {
                System.Console.WriteLine(Output);
                System.Console.WriteLine("Underweight");
            }
            else if (18.5 <= BMI && BMI < 25)
            {
                System.Console.WriteLine(Output);
                System.Console.WriteLine("Normal");
            }
            else if (25 <= BMI && BMI < 30)
            {
                System.Console.WriteLine(Output);
                System.Console.WriteLine("Overweight");
            }
            else if (BMI >= 30)
            {
                System.Console.WriteLine(Output);
                System.Console.WriteLine("Obese");
            }



        }
    }
}
