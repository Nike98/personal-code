using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object for the following class
            MethodOverload obj = new MethodOverload();

            int sum1 = obj.Add(4, 3);
            Console.WriteLine(" The Sum of two integers is : " + sum1);

            int sum2 = obj.Add(50, 90, 320);
            Console.WriteLine("\n The Sum of three integers is : " + sum2);

            Console.ReadLine();
        }
    }

    class MethodOverload
    {
        // Adding two Integer values
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Adding three Integer values
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
