//1.Пользователь вводит с клавиатуры два числа (начало и конец диапазона).
//Нужно вывести на экран:
//Все числа диапазона;
//Все числа диапазона в убывающем порядке;
//Все числа, кратные 7;
//Количество чисел, кратных 5.

//try
//{
//    int startNum = 0;
//int endNum = 0;
//int result = 0;

//Console.WriteLine("Enter start number");
//startNum = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter end number");
//endNum = Convert.ToInt32(Console.ReadLine());

//if (startNum > endNum)
//{
//    (startNum, endNum) = (endNum, startNum);
//}

//Console.Write("All numbers in the range: ");
//for (int i = startNum; i <= endNum; i++)
//{
//    if (i == endNum)
//    {
//        Console.WriteLine($"{i}.");
//    }
//    else
//    {
//        Console.Write($"{i}, ");
//    }
//} // All numbers in the range

//Console.Write("All numbers in the range in reverse order: ");
//for (int i = endNum; i >= startNum; i--)
//{
//    if (i == startNum)
//    {
//        Console.WriteLine($"{i}.");
//    }
//    else
//    {
//        Console.Write($"{i}, ");
//    }
//} // All numbers in the range in reverse order

//Console.Write("All numbers multiples of seven: ");
//for (int i = startNum; i <= endNum; i++)
//{
//    if (i % 7 == 0)
//    {
//        Console.Write($"{i}. ");
//    }
//    else if (i == endNum)
//    {
//        Console.WriteLine();
//    }
//}

//for (int i = startNum; i <= endNum; i++)
//{
//    if (i % 5 == 0)
//    {
//        result += 1;
//    }
//}
//Console.WriteLine($"The number of numbers that are multiples of five: {result}.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//2.Пользователь вводит с клавиатуры два числа.
//Нужно посчитать отдельно сумму четных, нечетных и чисел,
//кратных 9 в указанном диапазоне, а также среднеарифметическое каждой группы. 

//Console.WriteLine("Enter start number: ");
//int startNum = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter end number: ");
//int endNum = Convert.ToInt32(Console.ReadLine());

//int sum1 = 0, sum2 = 0, sum3 = 0;
//int quantity1 = 0, quantity2 = 0, quantity3 = 0;

//if (startNum > endNum)
//{
//    (startNum, endNum) = (endNum, startNum);
//}

//for (int i = startNum; i <= endNum; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum1 += i;
//        quantity1++;
//    }

//    if (i % 2 != 0)
//    {
//        sum2 += i;
//        quantity2++;
//    }

//    if (i % 9 == 0)
//    {
//        sum3 += i;
//        quantity3++;
//    }
//}

//int arithmeticMean1 = quantity1 > 0 ? sum1 / quantity1 : 0;
//int arithmeticMean2 = quantity2 > 0 ? sum2 / quantity2 : 0;
//int arithmeticMean3 = quantity3 > 0 ? sum3 / quantity3 : 0;

//Console.WriteLine($"Сумма четных чисел в диапазоне: {sum1}, а их среднеарифметическое {arithmeticMean1}.");
//Console.WriteLine($"Сумма нечетных чисел в диапазоне: {sum2}, а их среднеарифметическое {arithmeticMean2}.");
//Console.WriteLine($"Сумма чисел кратных 9 в диапазоне: {sum3}, а их среднеарифметическое {arithmeticMean3}.");



//Доп задания:
//1.Подсчитать количество целых чисел в диапазоне от 100 до 999 у которых есть две одинаковые цифры.

//int startNum = 100;
//int endNum = 999;

//Console.WriteLine($"Целые числа в диапазоне: ");
//for (int i = startNum; i <= endNum; i++)
//{
//    int num1 = i % 1000 / 100;
//    int num2 = i % 100 / 10;
//    int num3 = i % 10;

//    if (num1 == num2 || num2 == num3 || num3 == num1)
//    {
//        Console.Write($"{i} | ");
//    }
//}



//2.Показать на экран все простые числа в диапазоне, указанном пользователем.
//Число называется простым, если оно делится без остатка только на себя и на единицу.
//Например, три — это простое число, а четыре нет.

//Console.WriteLine("Введите начало диапазона: ");
//int startNum = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите конец диапазона: ");
//int endNum = Convert.ToInt32(Console.ReadLine());

//Console.Write("Простые числа в диапазоне: | ");

//for (int i = startNum; i <= endNum; i++)
//{
//    int result = 0;

//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            result += 1;
//            break;
//        }
//    }

//    if (result == 0)
//    {
//        Console.Write($"{i} | ");
//    }
//}

//1.Пользователь вводит с клавиатуры ширину и высоту прямоугольника. Требуется отобразить на экран
// заполненный прямоугольник с указанными высотой и
// шириной. Например, если пользователь ввёл высоту 3,
//а ширину 5 на экране будет выведено:
// *****
// *****
// *****


//Console.WriteLine("Введите ширину прямоугольника: ");
//int width = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите высоту прямоугольника: ");
//int height = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ваш прямоугольник: ");

//for (int i = 1; i <= height; i++)
//{
//    for (int j = 1; j <= width; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}



//2.Пользователь вводит с клавиатуры длину и ширину прямоугольника. 
// Требуется отобразить на экран незаполненный прямоугольник (отображаются только границы прямоугольника). 
// Размер длины и ширины равен введенным данным.

//Console.Write("Введите длину прямоугольника: ");
//int length = int.Parse(Console.ReadLine());

//Console.Write("Введите ширину прямоугольника: ");
//int width = int.Parse(Console.ReadLine());

//Отображаем прямоугольник с границами
//for (int i = 0; i < width; i++)  // По строкам (ширина)
//{
//    for (int j = 0; j < length; j++)  // По столбцам (длина)
//    {
//        if (i == 0 || i == width - 1 || j == 0 || j == length - 1)
//        {
//            Если на границе, то рисуем символ
//            Console.Write("*");
//        }
//        else
//        {
//            Внутри прямоугольника ничего не рисуем
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();  // Переход на новую строку после завершения столбцов