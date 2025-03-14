////Создать массив на 30 чисел и запонить случайными числами от 1 до 100.
////Отсортировать алгоритмом пузырьковой сортировки.
////Pазобраться как работает, продебажить и написать самостоятельно, не списывая.

////Ссылки: 
////https://programm.top/c-sharp/algorithm/array-sort/
////https://tproger.ru/digest/sorting-algorithms-visualized/

//namespace HomeWork8
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            const int lengthArray = 30;
//            int[] arr = new int[lengthArray];
//            NewArr(arr);

//            Show(arr);
//            Console.WriteLine("\n\n");
//            BubbleSort(arr);
//            Show(arr);
//        }

//        public static void NewArr(int[] arr)
//        {
//            var rand = new Random();
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = rand.Next(1, 100);
//            }
//        }

//        public static void Show(int[] array)
//        {
//            foreach (int i in array)
//            {
//                Console.Write($"{i}\t");
//            }
//        }

//        public static int[] BubbleSort(int[] array)
//        {
//            for (int i = 1; i < array.Length; i++)
//            {
//                bool arrSorted = true;
//                for (int j = 0; j < array.Length - 1; j++)
//                {
//                    if (array[j] > array[j + 1])
//                    {
//                        arrSorted = false;
//                        Swap(ref array[j], ref array[j + 1]);
//                    }
//                }
//                if (arrSorted)
//                {
//                    break;
//                }
//            }
//            return array;
//        }

//        //public static void Swap(ref int num1, ref int num2)
//        //{
//        //    if (num1 > num2)
//        //    {
//        //        (num1, num2) = (num2, num1);
//        //    }
//        //}

//        public static void Swap(ref int num1, ref int num2)
//        {
//            var temp = num1;
//            num1 = num2;
//            num2 = temp;
//        }
//    }
//}