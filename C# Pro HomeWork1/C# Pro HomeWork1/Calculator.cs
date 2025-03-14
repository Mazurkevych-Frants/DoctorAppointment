using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_HomeWork1
{

    public enum ArithmeticOperation
    {
        Add = '+',
        Subtraction = '-',
        Multiplication = '*',
        Division = '/',
        RemainderFromDivision = '%',
        Degree = '^'
    }

    public class Calculator
    {
        public double PerformOperation(double num1, double num2, ArithmeticOperation operation)
        {
            switch(operation)
            {
                case ArithmeticOperation.Add:
                    return Add(num1, num2);
                case ArithmeticOperation.Subtraction:
                    return Subtraction(num1, num2);
                case ArithmeticOperation.Multiplication:
                    return Multiplication(num1, num2);
                case ArithmeticOperation.Division:
                    return Division(num1, num2);
                case ArithmeticOperation.RemainderFromDivision:
                    return RemainderFromDivision(num1, num2);
                case ArithmeticOperation.Degree:
                    return Math.Pow(num1, num2);
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }

        public double Add(double num1, double num2) => num1 + num2; // можно выполнить так

        public double Subtraction(double num1, double num2) => num1 - num2; // можно так (синтаксический сахар?)

        public double Multiplication(double num1, double num2) => num1 * num2;

        public double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Error: Oops, you can't divide by zero.");
            }
            return num1 / num2;
        }

        public double RemainderFromDivision(double num1, double num2) => num1 % num2;

        public double Degree(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
