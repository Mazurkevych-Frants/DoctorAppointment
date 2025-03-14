using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HM3.Interface;

namespace HM3
{
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] myArray;

        private static Random rand = new Random();
        public MyArray(int size)
        {
            myArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                myArray[i] = rand.Next(1, 100);
            }
        }

        public void Show()
        {
            foreach (int i in myArray)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("\b\b.");
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }


        public int Max() => myArray.Max();

        public int Min() => myArray.Min();

        public float Avg() => (float)myArray.Average();

        public bool Search(int valueToSearch) => myArray.Contains(valueToSearch);

        public void SortAsc() => Array.Sort(myArray);

        public void SortDesc()
        {
            Array.Sort(myArray);
            Array.Reverse(myArray);
        }

        public void SortByParam(bool isAsc)
        {
            Array.Sort(myArray);
            if (!isAsc)
            {
                Array.Reverse(myArray);
            }
        }
    }
}
