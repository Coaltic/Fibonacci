using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static public int i;
        static decimal start = 0;
        static decimal second = 1;

        static void Main(string[] args)
        {
            
            Fibonacci(start, second);

            
        }

        static public void Fibonacci(decimal a, decimal b)
        {
            i++;
            decimal c = a + b;
            
            Console.Write(i + ": " + c);
            Ratio(a, b);

            a = b;
            b = c;

            

            if (i < 138) 
            {
                Fibonacci(a, b);
                
            }
            else
            {
                Console.ReadKey(true);
                //ExactFibonacci(start, second);

            }

            

        }

        static public void Ratio(decimal a, decimal b)
        {
            decimal c = a / b;
            Console.WriteLine("    Golden Ratio: " + c);
            //a = b;
            //b = c;

            //if (c > 1000000) { Console.ReadKey(true); }

            //Fibonacci(a, b);

        }

        /*static public void ExactFibonacci(decimal a, decimal b)
        {
            
            int i = 10;

            for (int y = 0; y <= i; y++)
            {
                decimal c = a + b;
                a = b;
                b = c;

                //y++;

                if (y >= i)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(i + ": " + c);

                    
                }
                else
                {
                    ExactFibonacci(a, b);
                }
            }



            Console.ReadKey(true);




        }*/
    }

}
