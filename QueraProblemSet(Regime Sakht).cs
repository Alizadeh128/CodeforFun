//https://quera.org/problemset/20256/

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
            int Red = 0;
            int Yellow = 0;
            int Green = 0;

            for(int i = 0; i < Input.Length; i++){

                if(Input[i] == 'R')
                Red++;
                else if(Input[i] == 'Y')
                Yellow++;
                else if(Input[i] == 'G')
                Green++;
            }

            if(Red > 2 || (Red > 1 && Yellow > 1) || Green == 0)
            System.Console.WriteLine("nakhor lite");
            else
            System.Console.WriteLine("rahat baash");


        }
    }
}
