//https://quera.org/problemset/175189/

// input:
// 2
// 11 5 6 5
// output:
// 5 11

// input:
// 6
// 1 2 3 6 4 5 6 21 
// output:
// 6 21

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
        string NumSessions = Console.ReadLine();
        string SizeSessions = Console.ReadLine();
        Double[] DoubleSizeSessions = new Double[SizeSessions.Length];

        string[] ChangedSizeSessions = SizeSessions.Split(' ');

        for (int i = 0; i < ChangedSizeSessions.Length; i++)
        {
          if(ChangedSizeSessions[i] == "")
          ChangedSizeSessions[i] = "0";
          DoubleSizeSessions[i] = Convert.ToInt32(ChangedSizeSessions[i]);
        }

        //  for (int i = 0; i < IntSizeSessions.Length; i++)
        // {
        //   System.Console.WriteLine(IntSizeSessions[i]);
        // }

        Array.Sort(DoubleSizeSessions);
        Double Sum = DoubleSizeSessions.Sum();
        Double Final = DoubleSizeSessions[DoubleSizeSessions.Length-1];
        Double Mid = Sum - (2*Final);

        Console.WriteLine(Mid +" "+ Final);  
    }
  }
}
