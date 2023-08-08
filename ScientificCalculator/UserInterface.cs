using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScientificCalculator
{
    public class UserInterface
    {
        private Calculator calculator;
        private static double num1;
        private static double num2;
        public UserInterface(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public static void CreateInterface()
        {

            while (true)
            {
                Console.WriteLine("WELCOME!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Indices");
                Console.WriteLine("6. Logarithm");
                Console.WriteLine("7. Squareroot");
                Console.WriteLine("8. Cuberoot");
                Console.WriteLine("9. Sine");
                Console.WriteLine("10. Cosine");
                Console.WriteLine("11. Tangent");
                Console.WriteLine("12. Cot");
                Console.WriteLine("13. Sec");
                Console.WriteLine("14. Cosec");
                Console.WriteLine("15. Exp");
                Console.WriteLine("16. Exit");
                int choice = int.Parse(Console.ReadLine());



                if (choice >= 1 && choice <= 5)
                {
                    Console.Write("Enter a number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Result: " + Calculator.Add(num1, num2));
                            break;

                        case 2:
                            Console.WriteLine("Result: " + Calculator.Subtract(num1, num2));
                            break;

                        case 3:
                            Console.WriteLine("Result: " + Calculator.Multiply(num1, num2));
                            break;

                        case 4:
                            try
                            {
                                Console.WriteLine("Result: " + Calculator.Divide(num1, num2));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                return;
                            }
                            break;

                        case 5:
                            Console.WriteLine("Result: " + Calculator.Power(num1, num2));
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else if (choice >= 6 && choice <= 15)
                {
                    Console.Write("Enter a number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case 6:
                            Console.WriteLine("Result: " + Calculator.Log(num1));
                            break;

                        case 7:
                            Console.WriteLine("Result: " + Calculator.SquareRoot(num1));
                            break;

                        case 8:
                            Console.WriteLine("Result: " + Calculator.CubeRoot(num1));
                            break;

                        case 9:
                            Console.WriteLine("Result: " + Calculator.Sin(num1));
                            break;

                        case 10:
                            Console.WriteLine("Result: " + Calculator.Cos(num1));
                            break;

                        case 11:
                            Console.WriteLine("Result: " + Calculator.Tan(num1));
                            break;

                        case 12:
                            Console.WriteLine("Result: " + Calculator.Cot(num1));
                            break;

                        case 13:
                            Console.WriteLine("Result: " + Calculator.Sec(num1));
                            break;

                        case 14:
                            Console.WriteLine("Result: " + Calculator.Csc(num1));
                            break;

                        case 15:
                            Console.WriteLine("Result: " + Calculator.Exp(num1));
                            break;


                        default:
                            break;
                    }

                }

                if (choice == 16)
                {
                    Console.WriteLine("Thanks for using the Calculator.");
                    break;
                }
                

                string userInput = Console.ReadLine();
                if (Validation.isNumeric(userInput))
                {
                    double number = double.Parse(userInput);
                }
            }
        }
    }
}
