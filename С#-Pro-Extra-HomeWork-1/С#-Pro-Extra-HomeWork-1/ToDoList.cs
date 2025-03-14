using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace С__Pro_Extra_HomeWork_1
{
    
    public enum AddTask
    {
        Create = 1,
        Update = 2,
        Delete = 3,
        Read = 4,
        Exit = 5
    }

    public class ToDoList
    {
        public void PerformAction(AddTask operation, int index, string task)
        {
            switch (operation)
            {
                case AddTask.Create:
                    Create(task);
                    break;
                case AddTask.Update:
                    Update(index, task);
                    break;
                case AddTask.Delete:
                    Delete(index);
                    break;
                case AddTask.Read:
                    Read();
                    break;
                case AddTask.Exit:
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }
        }

        List <string> toDoList = new List<string>();

        public void Create(string task) => toDoList.Add(task);

        public void Update(int index, string task)
        {
            if (index > 0 && index <= toDoList.Count)
            {
                toDoList[index - 1] = task;
            }
            else
            {
                Console.WriteLine("Incorrect index.");
            }
        }

        public void Delete(int index)
        {
            if (index > 0 && index <= toDoList.Count)
            {
                index--;
                toDoList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Incorrect index.");
            }
        }

        public void Read()
        {
            Console.WriteLine("To do list: ");
            int i = 1;
            foreach (var task in toDoList)
            {
                Console.WriteLine($"{i}. {task}");
                i++;
            }
        }
    }
}
