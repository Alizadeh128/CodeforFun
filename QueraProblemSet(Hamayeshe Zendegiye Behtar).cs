//https://quera.org/problemset/10325/

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

            string Output = "";
            int Row;
            int SeatNum;

            if (ArrInt[1] > 10)
                Output = Output + "Left";
            else
                Output = Output + "Right";

            Row = 11 - ArrInt[0];

            if (Output == "Right")
                SeatNum = ArrInt[1];
            else
                SeatNum = 21 - ArrInt[1];

            System.Console.WriteLine(Output + " " + Row + " " + SeatNum);




        }
    }
}
