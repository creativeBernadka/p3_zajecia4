using System;

namespace Calculator
{
    public class Calculator
    {
        public int AddNumbers (int first,  int second)
        {
            return first + second;
        }
        
        public int AddNumbers (string first,  string second)
        {
            return Convert.ToInt32(first) + Convert.ToInt32(second);
        }
        
        public int SubtractNumbers (int first,  int second)
        {
            return first - second;
        }
        
        public int SubtractNumbers (string first,  string second)
        {
            return Convert.ToInt32(first) - Convert.ToInt32(second);
        }
        public int MultiplyNumbers (int first,  int second)
        {
            return first * second;
        }
        public int MultiplyNumbers (string first,  string second)
        {
            return Convert.ToInt32(first) * Convert.ToInt32(second);
        }
        public double DivideNumbers (int first,  int second, out bool success)
        {
            if (second == 0)
            {
                success = false;
                return 0;
            }

            success = true;
            return (double) first / second;
        }
        
        public double DivideNumbers (string first,  string second, out bool success)
        {
            if (second == "0")
            {
                success = false;
                return 0;
            }

            success = true;
            return Convert.ToDouble(first) / Convert.ToDouble(second);
        }

        public double DivideNumbersWithException(int first, int second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException();
            }
            return (double) first / second;
        }
    }
}