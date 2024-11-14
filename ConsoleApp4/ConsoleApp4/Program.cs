using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Calculator
    {
      
        public int Add(int a, int b)
        {
            return a + b;
        }

        
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Sum of 2 numbers: " + calc.Add(5, 10)); 
            Console.WriteLine("Sum of 3 numbers: " + calc.Add(5, 10, 15));
        }
    }
}
