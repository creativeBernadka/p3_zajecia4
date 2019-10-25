using System;

namespace Calculator
{
    internal class Program
    {
        static string ReadNumber(string number)
        {
            Console.WriteLine("Podaj liczbe "+number+":");
            string text = Console.ReadLine();
            return text;
        }
        
        
        public static void Main(string[] args)
        {
            string text1 = ReadNumber("1");
            string text2 = ReadNumber("2");
            Console.WriteLine("Wybierz operacje:");
            string operation = Console.ReadLine();
            int number1 = Convert.ToInt32(text1);
            int number2 = Convert.ToInt32(text2);
            Calculator calculator = new Calculator();
            switch (operation) 
            {
                case "+":
                    Console.WriteLine(calculator.AddNumbers(number1, number2));
                    Console.WriteLine(calculator.AddNumbers(text1, text2));
                    break;
                case "-":
                    Console.WriteLine(calculator.SubtractNumbers(number1, number2));
                    Console.WriteLine(calculator.SubtractNumbers(text1, text2));
                    break;
                case "*":
                    Console.WriteLine(calculator.MultiplyNumbers(number1, number2));
                    Console.WriteLine(calculator.MultiplyNumbers(text1, text2));
                    break;
                case "/":
                    bool success;
                    double result = calculator.DivideNumbers(number1, number2, out success);
                    if (success)
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Podzielono przez zero");
                    }

                    try
                    {
                        Console.WriteLine(calculator.DivideNumbersWithException(number1, number2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Podzielono przez zero");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}