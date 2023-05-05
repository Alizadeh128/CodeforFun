//https://quera.org/problemset/31025/

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
            float[] myints = Input.Select(float.Parse).ToArray();
            int Output = Convert.ToInt32(myints[0]);
           
            for (int i = 0; i < myints[1]; i++){
                Output /= 2;
                myints[0] /= 2;
            }
            string Floatf = Convert.ToString(myints[0]);
            string Inti = Convert.ToString(Output);

            if (myints[0] < 0 && myints[1] == 0)
                System.Console.WriteLine(Output);
            else if (myints[0] >= 0)
                System.Console.WriteLine(Output);
                else if(Floatf == Inti)
                System.Console.WriteLine(Output);
                else
                System.Console.WriteLine(Output-1);


        }
    }
}
