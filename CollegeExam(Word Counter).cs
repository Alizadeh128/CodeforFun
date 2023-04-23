//برنامه‌ای که یه رشته‌ای رو بگیره و تعداد کلمات و تعداد تکرار هر کلمه رو بگه

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforFun
{
  class Program
  {
    static void Main(string[] args)
    {

        System.Console.Write("Please, Enter the String:\n");
        string Input = Console.ReadLine();
        string[] ChangedInput = Input.Split(" ");
        int[] Counter = new int[ChangedInput.Length];
        String[] Answer = new string[ChangedInput.Length];
        
        
        for ( int i = 0; i < ChangedInput.Length; i++)
        {
          for (int j = 0; j < ChangedInput.Length; j++)
          {
            if (ChangedInput[i] == ChangedInput[j])
            {
              Counter[i]++;
            }
          }
        }

        Console.WriteLine("Number of all Words is:{0}",ChangedInput.Length);

        for (int i = 0; i < ChangedInput.Length; i++){
        
          Answer[i]= "Number of Word \""+ ChangedInput[i] +"\" is: "+ Counter[i];

        }

        string[] Dist = Answer.Distinct().ToArray();

        foreach (var item in Dist)
        System.Console.WriteLine(item);
          
        
        
    }
  }
}
