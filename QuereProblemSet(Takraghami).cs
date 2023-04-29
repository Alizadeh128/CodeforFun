//https://quera.org/problemset/3539/

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
            Double DoubleInput = Convert.ToDouble(Input);
            string[] StringArray = new string[Input.Length];
            Double[] DoubleArray = new Double[Input.Length];

            for (int i = 0; i < Input.Length; i++)
                StringArray[i] = Input[i] + "";

            for (int i = 0; i < Input.Length; i++)
                DoubleArray[i] = Convert.ToInt32(StringArray[i]);

            Double Sum = DoubleArray.Sum();
            string SumString = DoubleArray.Sum().ToString();
            string[] SumStringAgain = new string[SumString.Length];
            Double[] SumDoubleAgain = new Double[SumString.Length];

            while (Sum > 9)
            {

                for (int i = 0; i < SumString.Length; i++)
                    SumStringAgain[i] = SumString[i] + "";

                for (int i = 0; i < SumString.Length; i++)
                    SumDoubleAgain[i] = Convert.ToDouble(SumStringAgain[i]);

                Sum = SumDoubleAgain.Sum();
                SumString = SumDoubleAgain.Sum().ToString();

            }

            System.Console.WriteLine(Sum);






        }
    }
}
