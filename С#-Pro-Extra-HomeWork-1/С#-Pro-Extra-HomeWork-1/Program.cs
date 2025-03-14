//Напишите список дел (todo list), реализуйте все crud операции и добавьте функцию поиска по коллекции

using С__Pro_Extra_HomeWork_1;

namespace C__Pro_Extra_HomeWork1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();
            while (true)
            {
                (int selectAction, int index, string task) = AcceptUserData();
                AddTask addTask = (AddTask)selectAction;

                toDoList.PerformAction(addTask, index, task);

                if (addTask == AddTask.Exit)
                {
                    break;
                }
            }
        }

        public static (int, int, string) AcceptUserData()
        {
            int selectAction = 0;
            int index = 0;
            string task = "-";

            try
            {
                Console.WriteLine("Выберите действие: 1 - добавить, 2 - изменить, 3 - удалить, 4 - посмотреть все задачи, 5 - выкл");
                selectAction = int.Parse(Console.ReadLine());
                if (selectAction == 2 || selectAction == 3)
                {
                    Console.WriteLine("Введите номер задачи");
                    index = int.Parse(Console.ReadLine());
                }

                if (selectAction == 1 || selectAction == 2)
                {
                    Console.WriteLine("Введите задачу");
                    task = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return (selectAction, index, task);
        }
    }
}