//https://quera.org/problemset/4065/

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
            //Convert String to String Array and remove empty(blank) values
            string[] ArrInput = Input.Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            // Convert String Array to Int Array
            int[] ArrInt = ArrInput.Select(int.Parse).ToArray();
            int Rep = ArrInt[2];
            int Output = (ArrInt[2] / 2) * (ArrInt[0] + ArrInt[1]);

            if (ArrInt[2] % 2 != 0)
                Output += ArrInt[0];

            System.Console.WriteLine(Output);


        }
    }
}
