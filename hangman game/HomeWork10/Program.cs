//Создать программу "список дел". (List)
//Реализовать:
//добавление задачи в список задач
//изменение задачи (найти по индексу)
//удаление задачи (найти по индексу)
//Задача представляет из себя строчку (string).

//namespace HomeWork9
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            var toDoList = new List<string>();

//            while (true)
//            {
//                Console.WriteLine("Выберите функцию: ");
//                Console.WriteLine("1 - добавить задачу, 2 - изменение задачи, 3 - удаление задачи, 4 - закончить редактирование списка дел");
//                int select1 = int.Parse(Console.ReadLine());

//                switch (select1)
//                {
//                    case 1:
//                        Console.WriteLine("Добавьте новую задачу: ");
//                        toDoList.Add(Console.ReadLine());
//                        break;
//                    case 2:
//                        Console.WriteLine("Выберите задачу по ее номеру которую хотите изменить:");
//                        int num1 = int.Parse(Console.ReadLine());
//                        toDoList[num1 - 1] = Console.ReadLine();
//                        break;
//                    case 3:
//                        Console.WriteLine("Выберите задачу по ее номеру которую хотите удалить:");
//                        int num2 = int.Parse(Console.ReadLine());
//                        toDoList.RemoveAt(num2 - 1);
//                        break;
//                    case 4:
//                        Console.WriteLine("Редактирование списка дел завершено.");
//                        break;
//                    default:
//                        Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 4.");
//                        continue;
//                }

//                if (select1 == 4)
//                {
//                    break;
//                }
//            }

//            Console.WriteLine("Хотите увидеть весь список?");
//            Console.WriteLine("1 - да, 2 - нет");
//            int select2 = int.Parse(Console.ReadLine());

//            switch (select2)
//            {
//                case 1:
//                    Console.WriteLine("Список задач:");
//                    ShowList(toDoList);
//                    break;
//                case 2:
//                    break;
//            }
//        }

//        public static void ShowList(List<string> tasks)
//        {
//            foreach (string task in tasks)
//            {
//                Console.WriteLine(task);
//            }
//        }
//    }
//}


//Дополнительно:
//Написать игру "Угадай число" используя бинарный поиск.
//Вывести кол-во попыток.