//1.Написать, программу, которая вычисляет прибыль фирмы за 6 месяцев. Пользователь вводит прибыль фирмы за каждый месяц.

//int numberOfMonths = 6;
//int[] profit = new int[numberOfMonths];

//int sumProfit = 0;

//for (int i = 0; i < numberOfMonths; i++)
//{
//    Console.WriteLine($"Введите прибль за {i + 1} месмяц:");
//    int num = Convert.ToInt32(Console.ReadLine());
//    profit[i] = num;
//    sumProfit += num;
//}

//Console.WriteLine($"Company profit for 6 months: {sumProfit}");


//2.Пользователь вводит прибыль фирмы за год (12 месяцев). Необходимо определить месяц, в котором
//прибыль была максимальна и месяц, в котором прибыль была минимальна.



//int[] profit = new int[12];

//for (int i = 0; i < profit.Length; i++)
//{
//    Console.WriteLine($"Enter profit for {i + 1} month:");
//    profit[i] = int.Parse(Console.ReadLine());
//}

//int maxProfit = profit[0];
//int minProfit = profit[0];
//int maxMonth = 1;
//int minMonth = 1;

//for (int i = 0; i < profit.Length; i++)
//{
//    if (profit[i] > maxProfit)
//    {
//        maxProfit = profit[i];
//        maxMonth = i + 1;
//    }

//    if (profit[i] < minProfit)
//    {
//        minProfit = profit[i];
//        minMonth = i + 1;
//    }
//}

//Console.WriteLine($"Max profit: {maxProfit}$, it was in {maxMonth} month");
//Console.WriteLine($"Min profit: {minProfit}$, it was in {minMonth} month");

//3.Сжать (сдвинуть элементы) массив, удалив из него все 0, и заполнить освободившиеся справа элементы значениями -1.