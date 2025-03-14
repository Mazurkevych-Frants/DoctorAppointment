// Игра виселица. Игра выбирает одно слово из списка, дает подсказку игроку что это за слово.
// Игрок в свою очередь должен последовательно угадывать буквы из слова,
// у него есть попытки в количестве длины слова (привет = 6 бук = 6 попыток)
// Если игрок угадывает букву ему программа выводит зашифрованное слово где открывается та буква которую он угадал
// Если игрок истратил все свои попытки и не угадал слово, он проиграл (умер, гы)

//Console.WriteLine("Enter 1 numbers: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 2 numbers: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 3 numbers: ");
//int num3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 4 numbers: ");
//int num4 = Convert.ToInt32(Console.ReadLine());

//int res1 = num1 * 1000;
//int res2 = num2 * 100;
//int res3 = num3 * 10;
//int res4 = num4;

//int allResult = res1 + res2 + res3 + res4;

//Console.WriteLine($"Yours numbers: {allResult}");

// next task


//Console.WriteLine("Enter a six-digit number: ");
//int numbers = Convert.ToInt32(Console.ReadLine());

//int num1 = numbers % 1000000 / 100000;
//int num2 = numbers % 100000 / 10000;
//int num3 = numbers % 10000 / 1000;
//int num4 = numbers % 1000 / 100;
//int num5 = numbers % 100 / 10;
//int num6 = numbers % 10;

//int res1 = num6 * 100000;
//int res2 = num5 * 10000;
//int res3 = num4 * 1000;
//int res4 = num3 * 100;
//int res5 = num2 * 10;
//int res6 = num1;

//int allResult = res6 + res5 + res4 + res3 + res2  + res1;

//Console.WriteLine($"Your reversed numbe: {allResult}");




//1.Пользователь вводит с клавиатуры целое шестизначное число. Написать программу, которая определяет,
//является ли введенное число — счастливым.
//Счастливым считается шестизначное число, у которого сумма первых 3 цифр равна сумме
//вторых трех цифр.
//Если пользователь ввел не шестизначное число — показать сообщение об ошибке.

//using System.ComponentModel.DataAnnotations;

//Console.WriteLine("Enter a six - digit number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int num1 = number % 1000000 / 100000;
//int num2 = number % 100000 / 10000;
//int num3 = number % 10000 / 1000;
//int num4 = number % 1000 / 100;
//int num5 = number % 100 / 10;
//int num6 = number % 10;

//int sum1to3 = num1 + num2 + num3;
//int sum4to6 = num4 + num5 + num6;

//if (number >= 1000000 || number <= 100000)
//{
//    Console.WriteLine("You have not entered a six-digit number.");
//}
//else if (sum1to3 == sum4to6)
//{
//    Console.WriteLine("Your ticket is lucky");
//}
//else
//{
//    Console.WriteLine("Your ticket is not lucky");
//}


//2. Написать программу подсчета стоимости разговора для
//разных мобильных операторов.
//Пользователь вводит длительность разговора и выбирает с какого на какой оператора он звонит.
//Тариф за минуту разговора записать в виде констант для каждого оператора.
//Вывести стоимость на экран.

//const int life = 4;
//const int kievstar = 6;
//int costOfCall = 0;

//Console.WriteLine("Enter: 1 - life, 2 - kievstar");
//int operatorSelection = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("How long will you talk?");
//int talkTime = Convert.ToInt32(Console.ReadLine());

//if (operatorSelection != 1 && operatorSelection != 2)
//{
//    Console.WriteLine("You have selected the wrong operator.");
//}
//else if (operatorSelection == 1)
//{
//    costOfCall = life * talkTime;
//    Console.WriteLine($"Cost of call: {costOfCall}");
//}
//else if (operatorSelection == 2)
//{
//    costOfCall = kievstar * talkTime;
//    Console.WriteLine($"Cost of call: {costOfCall}");
//}
//else
//{
//    Console.WriteLine("You have entered incorrect data");
//}