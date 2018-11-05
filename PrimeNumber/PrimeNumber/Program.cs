using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100;  counter++)
            {
               if (counter == 3 || counter == 5 || counter == 7 || counter == 2)
                    Console.Write(" " + counter + " ");

               else if ( counter % 5 ==0 || counter % 7==0 || counter % 2==0 || counter % 3==0 ) 
                    Console.Write(" ");

                else 
                    Console.Write(" " + counter + " ");

            
            }
            Console.Read();
        }
    }
}
