//https://quera.org/problemset/3429/

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

       int Input = Convert.ToInt32(Console.ReadLine());

       if(Input > 100)
       System.Console.WriteLine("Steam");
       else if(Input < 0)
       System.Console.WriteLine("Ice");
       else
       System.Console.WriteLine("Water");
        
    }
  }
}
