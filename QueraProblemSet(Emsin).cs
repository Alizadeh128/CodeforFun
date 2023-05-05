//https://quera.org/problemset/28947/

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
            string[] HaftSin = new string[7]{"sib","serke","samanoo","sabze","sir","somagh","senjed"};

            for(int i = 0; i < Input; i++)
                System.Console.WriteLine(HaftSin[i]);

        }
    }
}
