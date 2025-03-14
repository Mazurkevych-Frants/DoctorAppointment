//1.Пользователь с клавиатуры вводит 5 оценок студента.
//Определить, допущен ли студент к экзамену.
//Студент получает допуск, если его средний балл 4 балла и выше.

//Console.WriteLine("Enter grades: 1 - 12");
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());
//int num4 = Convert.ToInt32(Console.ReadLine());
//int num5 = Convert.ToInt32(Console.ReadLine());

//int sum = (num1 + num2 + num3 + num4 + num5) / 5;

//string result = sum >= 4 ? "Студент получает допуск" : "Студент не получает допуск";
//Console.WriteLine(result);





//2. Пользователь вводит с клавиатуры число.
//Если оно четное, умножить его на три, иначе — поделить на два.
//Результат вывести на экран.

//Console.WriteLine("Enter number");
//double num = Convert.ToInt32(Console.ReadLine());

//double result = num % 2 == 0 ? num * 3 : num / 2;
//Console.WriteLine(result);



//3. Написать программу-калькулятор.
//Пользователь вводит два числа и выбирает арифметическое действие.
//Вывести на экран результат. Использовать switch и enum

//Console.WriteLine("Enter the first number:");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter arithmetic operations:");
//char operation = Convert.ToChar(Console.ReadLine());

//Console.WriteLine("Enter the second number:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//ArithmeticOperations operations = (ArithmeticOperations)operation;
//int result = 0;

//switch (operations)
//{
//    case ArithmeticOperations.Plus:
//        result = num1 + num2;
//        Console.WriteLine($"Result: {result}");
//        break;
//    case ArithmeticOperations.Minus:
//        result = num1 - num2;
//        Console.WriteLine($"Result: {result}");
//        break;
//    case ArithmeticOperations.Divide:
//        result = num1 / num2;
//        Console.WriteLine($"Result: {result}");
//        break;
//    case ArithmeticOperations.Multiply:
//        result = num1 * num2;
//        Console.WriteLine($"Result: {result}");
//        break;
//}

//enum ArithmeticOperations
//{
//    Plus = '+',
//    Minus = '-',
//    Multiply = '*',
//    Divide = '/'
//}




//Доп задание:
//Зарплата менеджера составляет 200$ + процент от продаж, продажи до 500$ — 3%, от 500 до 1000 — 5%, свыше 1000 — 8%.
//Пользователь вводит с клавиатуры уровень продаж для трех менеджеров.
//Определить их зарплату, определить лучшего менеджера, начислить ему премию 200$,
//вывести итоги на экран.
//Примечание: уровень продаж у всех трех менеджеров разный.
//пример с пары ниже в файле.

Console.WriteLine("Сколько продал 1 менеджер");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сколько продал 2 менеджер");
double num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сколько продал 3 менеджер");
double num3 = Convert.ToInt32(Console.ReadLine());

double zp1 = 0;
double zp2 = 0;
double zp3 = 0;

if (num1 < 500)
{
    zp1 = 200 + num1 * (3.0 / 100);
}
else if (500 <= num1 && num1 < 1000)
{
    zp1 = 200 + num1 * (5.0 / 100);
}
else
{
    zp1 = 200 + num1 * (8.0 / 100);
}

if (num2 < 500)
{
    zp2 = 200 + num2 * (3.0 / 100);
}
else if (500 <= num2 && num2 < 1000)
{
    zp2 = 200 + num2 * (5.0 / 100);
}
else
{
    zp2 = 200 + num2 * (8.0 / 100);
}

if (num3 < 500)
{
    zp3 = 200 + num3 * (3.0 / 100);
}
else if (500 <= num3 && num3 < 1000)
{
    zp3 = 200 + num3 * (5.0 / 100);
}
else
{
    zp3 = 200 + num3 * (8.0 / 100);
}

if (zp1 > zp2 && zp1 > zp3)
{
    zp1 += 200;
}
else if (zp2 > zp3 && zp2 > zp1)
{
    zp2 += 200;
}
else
{
    zp3 += 200;
}

Console.WriteLine($"Зарплата 1 менеджера: {zp1}$");
Console.WriteLine($"Зарплата 2 менеджера: {zp2}$");
Console.WriteLine($"Зарплата 3 менеджера: {zp3}$");