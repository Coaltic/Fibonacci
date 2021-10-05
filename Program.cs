using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static public int i = 100;
        static decimal start = 0;
        static decimal second = 1;

        static public decimal[] fibs = new decimal[200];

        static void Main(string[] args)
        {

            for (int y = 0; y <= i; y++)
            {
                Console.WriteLine(y + ": " + Fib(y));
            }
                
            Console.ReadKey(true);
        }
        static public void Fibonacci(decimal a, decimal b)
        {
            //i++;
            decimal c = a + b;
            
            Console.Write(i + ": " + c);
            //Ratio(a, b);

            a = b;
            b = c;

            


            /*if (i < 138) 
            {
                Fibonacci(a, b);
                
            }
            else
            {
                Console.ReadKey(true);
                //ExactFibonacci(start, second);

            }*/

            

        }

        static public void Ratio(decimal a, decimal b)
        {
            decimal c = a / b;
            Console.WriteLine("    Golden Ratio: " + c);

        }

        static public void CacheFib(decimal i, decimal number)
        {
            int k = Decimal.ToInt32(i);
            fibs[k] = number;
        }

        static public decimal Fib(decimal i)
        {
            int k;
            if (i == 0) { CacheFib(i, 0); return 0; }
            if (i == 1) { CacheFib(i, 1); return 1; }

            if (fibs[k = Decimal.ToInt32(i)] == 0)
            {
                decimal a = Fib(i - 1);
                decimal b = Fib(i - 2);
                decimal c = a + b;
                CacheFib(i, c);
                return c;
            }
            else
            {
                decimal a = fibs[k = Decimal.ToInt32(i - 1)];
                decimal b = fibs[k = Decimal.ToInt32(i - 2)];
                decimal c = a + b;
                CacheFib(i, c);
                return c;
            }
            
        }
    }

}

//Fib(10) == Fib(8) + Fib(9) -----> Fib(8) == Fib(7) + Fib(6)