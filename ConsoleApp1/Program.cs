using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List <int> Numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] % 2 == 0)
                {
            
                    Numbers.RemoveAt(i);
                    
                    

                }
            }
          for (int n =  0; n < Numbers.Count; n++)
            {
                Console.Write("  " + Numbers[n]);
            }
            Console.ReadKey();

        }
    }
}
