using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {

        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string[] array = new string[30];
        int[] array1 = new int [30];
        char c = ' ';
        int j = 0;

        for (int i = 0; i < b.Length; i++)
        {
           
           if(b[j] == c)
           j++;

          if(b[j] != c){
            array[j] = Convert.ToString(b[j]);
            if (j+1 == b.Length)
                    break;

            if(j+1 <= b.Length-1)
              j++;

            if(b[j] != c){
                array[j-1] = array[j-1] + b[j];
                j++;
              }
              if (j == b.Length)
                    break;

          }
           
           
        }

          for (int i = 0; i < array1.Length; i++)
             array1[i] = Convert.ToInt32(array[i]);
        
        Array.Sort(array1);
        int sum = array1.Sum();
        int final = array1[29];
        int mid = sum - (2*final);

        System.Console.WriteLine(mid +" "+final);
        

    }
  }
}
