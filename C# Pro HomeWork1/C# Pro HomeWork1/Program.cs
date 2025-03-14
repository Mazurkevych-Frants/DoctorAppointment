//Створити клас калькулятор.
//Реалізувати основні методи: додавання, віднімання, множення, розподіл, тощо.
//Використовувати Git.

namespace C__Pro_HomeWork1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Calculator---");

            (double num1, double num2, char arithmeticOperator) = AcceptUserData();

            try
            {
                ArithmeticOperation operation = (ArithmeticOperation)arithmeticOperator;
                Calculator calculator = new Calculator();
                double result = calculator.PerformOperation(num1, num2, operation);
                Console.WriteLine($"Result: {num1} {arithmeticOperator} {num2} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static (double, double, char) AcceptUserData()
        {
            double num1 = 0;
            double num2 = 0;
            char arithmeticOperator = '0';

            try
            {
                Console.WriteLine("Enter first num: ");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second num: ");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter arithmetic operator: +, -, *, /, %, ^");
                arithmeticOperator = char.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return (num1, num2, arithmeticOperator);
        }
    }
}
