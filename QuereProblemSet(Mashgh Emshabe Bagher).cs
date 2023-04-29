//https://quera.org/problemset/10230/

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
       string[] ChangedInput = Input.Trim().Split(' ');
       int[] ChangedIntInput = new int[ChangedInput.Length];
       int Flag = 1;
       int SumAngles = 0;
       
       for (int i = 0; i < ChangedInput.Length; i++)

        ChangedIntInput[i] = Convert.ToInt32(ChangedInput[i]);

        for (int i = 0; i < ChangedIntInput.Length; i++){
          
          SumAngles += ChangedIntInput[i];

          if(ChangedIntInput[i] < 1 || ChangedIntInput[i] > 179){
          Flag = 0;
          break;}

          else if(SumAngles > 180){
          Flag = 0;
          break;}

          else if(i>2){
          Flag = 0;
          break;}

        }
        if(SumAngles < 180)
        Flag = 0;


        if (Flag == 1)
        System.Console.WriteLine("Yes");
        else
        System.Console.WriteLine("No");
       
       
    }
  }
}
