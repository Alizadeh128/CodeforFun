//https://quera.org/problemset/280/

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


       int Flag = 1;
       int[] Input = new int[3];

       for (int i = 0; i < 3; i++){

        Input[i] = Convert.ToInt32(Console.ReadLine());

        if(Input[i] == 0){
        Flag = 0;
        break;
        }
       }

        Array.Sort(Input);

        if(Input[0]*Input[0] + Input[1]*Input[1] != Input[2]*Input[2])
        Flag = 0;

        if (Flag == 1)
        System.Console.WriteLine("YES");
        else
        System.Console.WriteLine("NO");
       
       
    }
  }
}
