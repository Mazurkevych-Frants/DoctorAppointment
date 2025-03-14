//1.Пользователь вводит число.
// Определить количество цифр в этом числе, посчитать их сумму и среднее арифметическое. Определить количество нулей в этом числе.
// Общение с пользователем организовать через меню. (switch)

//Console.WriteLine("Enter your number: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int action = 0;

//while (true)
//{
//    action = 0;
//    Console.WriteLine("Select an action: ");
//    Console.WriteLine("1 - Find out the number of digits");
//    Console.WriteLine("2 - Find out the sum");
//    Console.WriteLine("3 - Find out the arithmetic mean");
//    Console.WriteLine("4 - Find out the number of zeros");
//    Console.WriteLine("5 - Finish program");
//    action = Convert.ToInt32(Console.ReadLine());

//    int digitCount = 0;
//    int sumNumbers = 0;
//    int numberOfZero = 0;
//    int tempNumber = number;
//    while (tempNumber != 0) // узнает сумму и количество введенных цисел
//    {
//        int digit = tempNumber % 10;
//        sumNumbers += digit;
//        tempNumber /= 10;
//        digitCount++;
//        if (digit == 0)
//        {
//            numberOfZero++;
//        }
//    }

//    int arithmeticMean = digitCount != 0 ? sumNumbers / digitCount : 0;

//    Actions chois = (Actions)action;

//    switch (chois)
//    {
//        case Actions.DigitCount:
//            Console.WriteLine($"Number of digits: {digitCount}");
//            break;
//        case Actions.Sum:
//            Console.WriteLine($"Sum: {sumNumbers}");
//            break;
//        case Actions.ArithmeticMean:
//            Console.WriteLine($"Arithmetic mean: {arithmeticMean}");
//            break;
//        case Actions.NumberOfZeros:
//            Console.WriteLine($"Number of zeros: {numberOfZero}");
//            break;
//        case Actions.Finish:
//            Console.WriteLine("The program is disabled.");
//            break;
//    }
//    if (action == 5)
//    {
//        break;
//    }
//}

//enum Actions
//{
//    DigitCount = 1,
//    Sum = 2,
//    ArithmeticMean = 3,
//    NumberOfZeros = 4,
//    Finish = 5
//}




//2.Написать программу, которая проверяет пользователя на знание таблицы умножения.
// Программа выводит на экран два числа, пользователь должен ввести их произведение.
// Разработать несколько уровней сложности
// (отличаются сложностью и количеством вопросов).
// Вывести пользователю оценку его знаний.

