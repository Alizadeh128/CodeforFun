//https://quera.org/problemset/2636/

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
            string[] Input = Console.ReadLine().Split(' ').Select(a => a.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int[] myInts = Input.Select(int.Parse).ToArray();
            int[] Output = new int[6];

            if (myInts[0] == 1)
                Output[0] = 0;
            else
                Output[0] = 1 - myInts[0];

            if (myInts[1] == 1)
                Output[1] = 0;
            else
                Output[1] = 1 - myInts[1];

            if (myInts[2] == 2)
                Output[2] = 0;
            else
                Output[2] = 2 - myInts[2];

            if (myInts[3] == 2)
                Output[3] = 0;
            else
                Output[3] = 2 - myInts[3];

            if (myInts[4] == 2)
                Output[4] = 0;
            else
                Output[4] = 2 - myInts[4];

            if (myInts[5] == 8)
                Output[5] = 0;
            else
                Output[5] = 8 - myInts[5];

            foreach (var item in Output)
            {
                System.Console.Write(item + " ");
            }


        }
    }
}
