using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator
{
    public class Calculator
    {
        public static double Add(double num1, double num2) 
        {
            return (num1 + num2); 
        }

        public static double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public static double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public static double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }

        public static double Power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public static double Log(double num)
        {
            return Math.Log(num);
        }

        public static double SquareRoot(double num)
        {
            return Math.Sqrt(num);
        }

        public static double CubeRoot(double num)
        {
            return Math.Cbrt(num);
        }

        public static double Sin(double num)
        {
            return Math.Sin(num);
        }

        public static double Cos(double num)
        {
            return Math.Cos(num);
        }

        public static double Tan(double num)
        {
            return Math.Tan(num);
        }

        public static double Cot(double num)
        {
            return 1 / Math.Tan(num);
        }

        public static double Sec(double num)
        {
            return 1 / Math.Cos(num);
        }

        public static double Csc(double num)
        {
            return 1 / Math.Sin(num);
        }

        public static double Exp(double num)
        {
            return Math.Exp(num);
        }

        public double Result(int choice)
        {
            Console.WriteLine("Result "+ choice);
            return choice;
        }
        
    }
}
