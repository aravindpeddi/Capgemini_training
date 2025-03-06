//**Method Overloading in a Calculator Class**

//Implement a `Calculator` class with overloaded methods `Add()`. It should accept two integers, three integers, and two double values separately. Demonstrate how method overloading works.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c__Assignment;

namespace c__Assignment
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

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Calculator calculator = new Calculator();

    //        int sum1 = calculator.Add(2, 3);
    //        Console.WriteLine($"Sum of 2 and 3: {sum1}");

    //        int sum2 = calculator.Add(1, 2, 3);
    //        Console.WriteLine($"Sum of 1, 2 and 3: {sum2}");

    //        double sum3 = calculator.Add(2.5, 3.5);
    //        Console.WriteLine($"Sum of 2.5 and 3.5: {sum3}");
    //    }
    //}
}