//Массивы:
//Напишите программу, которая создает двухмерный массив и заполняет его по следующему
//принципу: пользователь вводит число (например, 3) первый элемент массива принимает значение этого числа,
//последующий элемент массива принимает значение этого числа + 1 (т.е. 4 для нашего примера), третий
//элемент массива предыдущий элемент + 1 (т.е. 5 для нашего примера). Созданный массив вывести на экран.

//Console.WriteLine("Введите кол-вл строк в массиве: ");
//int lenghtArr = int.Parse(Console.ReadLine());
//int[,] arr = new int[lenghtArr, 2];

//Console.WriteLine("Введите первое число: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int num2 = int.Parse(Console.ReadLine());

//for (int i = 0; i < lenghtArr; i++)
//{
//    arr[i, 0] = num1;
//    num1++;
//}

//for (int i = 0; i < lenghtArr; i++)
//{
//    arr[i, 1] = num2;
//    num2++;
//}

//Console.WriteLine("Созданный массив:");
//for (int i = 0; i < lenghtArr; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write(arr[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Функции:

//Задание 1.Написать функцию, которая принимает два параметра: основание степени и показатель степени,
//и вычисляет степень числа на основе полученных данных. 

//void Degree(int num1, int num2)
//{
//    int result = num1;
//for (int i = 1; i < num2; i++)
//{
//    result *= num1;

//}
//Console.WriteLine($"Степень числа: {result}");
//}

//Console.WriteLine("Введите число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите степень: ");
//int number2 = int.Parse(Console.ReadLine());

//Degree(number1, number2);

//Задание 2. Написать функцию, которая получает в качестве параметров 2 целых числа и возвращает
//сумму чисел из диапазона между ними. 

//void ArrSum(int num1, int num2)
//{
//    int sum = 0;
//for (int i = num1; i <= num2; i++)
//{
//    sum += i;
//}
//Console.WriteLine($"Сумма чисел в диапазоне: {sum}");
//}

//Console.WriteLine("Введите первое число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine());

//ArrSum(number1, number2);

//Задание 3. Число называется совершенным, если сумма всех его делителей равна ему самому.
//Напишите функцию поиска таких чисел во введенном интервале. 

void Perfect(int num1, int num2)
{
    int sum = 1;
    Console.Write("Совершенные числа в диапазоне: ");
    for (int i = num1; i < num2; i++)
    {
        sum = 1;
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                sum += j;
            }
        }

//    if (i != 1)
//    {
//        if (sum == i)
//        {
//            Console.Write($"{i} ");
//        }
//    }
//}
//}

//Console.WriteLine("Введите первое число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine());

//Perfect(number1, number2);


//Задание 4. Написать функцию, выводящую на экран переданную ей игральную карту. 

//void WhyCard(string nameCard)
//{

//}


//Задание 5. Написать функцию, которая определяет, является ли «счастливым» шестизначное число.

//void LuckyTicket(int num1, int num2)
//{

//}