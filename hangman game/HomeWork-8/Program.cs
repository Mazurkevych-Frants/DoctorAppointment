//Задание 1. 
//Написать рекурсивную функцию нахождения степени числа.

//namespace HomeWork8
//{
//    public class Program
//    {

//public static void Main()
//{
//    try
//    {
//        Console.WriteLine("Enter number:");
//        int number = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter degree:");
//        int degree = int.Parse(Console.ReadLine());

//        if (degree < 0)
//        {
//            throw new ArgumentException("Error: Degree cannot be negative.");
//        }

//        Console.WriteLine($"{number} to the degree {degree} = {Degree(number, degree)}");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

//public static int Degree(int number, int degree)
//{
//    if (degree == 0)
//    {
//        return 1;
//    }
//    else
//    {
//        return number * Degree(number, degree - 1);
//    }
//}

//public static int Degree(int number, int degree)
//{
//    int result = number;
//    for (int i = 1; i < degree; i++)
//    {
//        result *= number; 
//    }
//    return result;
//}	        
//    }
//}



//Задание 2. 
//Написать рекурсивную функцию, которая выводит N звезд в ряд, число N задает пользователь.
//Проиллюстрируйте работу функции примером.

//namespace HomeWork8
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            try
//            {
//                Console.WriteLine("Enter the number of stars: ");
//                int numStars = int.Parse(Console.ReadLine());

//                if (numStars <= 0)
//                {
//                    throw new ArgumentException("Error: The number of stars cannot be negative or equal to zero.");
//                }

//                Stars(numStars);
//                Console.WriteLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }

//        public static void Stars(int num)
//        {
//            if (num <= 0)
//            {
//                return;
//            }

//            Console.Write("*");
//            if (num > 1)
//            {
//                Stars(num - 1);
//            }
//        }
//    }
//}

//Задание 3. 

//Написать рекурсивную функцию, которая вычисляет сумму всех чисел в диапазоне от a до b.
//Пользователь вводит a и b. Проиллюстрируйте работу функции примером.

//namespace HomeWork8
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            try
//            {
//                int startRange = GetInput("Enter start range: ");
//                int endRange = GetInput("Enter end range: ");

//                if (startRange == 0 && endRange == 0)
//                {
//                    throw new ArgumentException("Error: The range of numbers entered is incorrect.");
//                }

//                if (startRange > endRange)
//                {
//                    (startRange, endRange) = (endRange, startRange);
//                }

//                Console.WriteLine($"The sum of numbers from {startRange} to {endRange} is {SumRange(startRange, endRange)}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine (ex.Message);
//            }
//        }

//        public static int GetInput (string input)
//        {
//            Console.WriteLine(input);
//            return int.Parse(Console.ReadLine());
//        } // функция для получения одного вводимого числа пользователем (перед этим выводя просьбу на экран)

//        public static int SumRange(int num1, int num2)
//        {
//            if (num1 > num2)
//            {
//                return 0;
//            }
//            else
//            {
//                return num1 + SumRange(num1 + 1, num2);
//            }
//        } // функция для получения суммы в вводимом диапазоне
//    }
//}

//Дополнительно:
//Напишите рекурсивную функцию, которая принимает одномерный массив из 100 целых чисел заполненных случайным образом и находит позицию,
//с которой начинается последовательность из 10 чисел, сумма которых минимальна.