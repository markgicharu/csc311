using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class method
    {
        static void Main(string[] args)
        {
            //getNumber();
            int x,y;
            Console.WriteLine("Enter the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(getSum(x, y));
        }

        public static void getNumber()
        {
            Console.WriteLine("This is a void method");
        }

        private static int getSum(int b, int c) 
        {
            int sum = b + c;

            return sum;
        }
    }
}
