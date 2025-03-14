//Задание 1.
//Пользователь с клавиатуры вводит некоторый текст. 
//Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.
//Например, если пользователь ввёл: «today is a good day for walking. i will try to walk near the sea». 
//Результат работы приложения: «Today is a good day for walking. I will try to walk near the sea».

//namespace HomeWork9
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            //Console.WriteLine("Введите текст:");
//            //string text = Console.ReadLine();
//            string text = "today we went for a walk. we liked it. it was cool.";

//            string newText = NewText(text);

//            Console.WriteLine(newText);
//        }

//        public static string NewText(string text)
//        {
//            char[] newText = text.ToCharArray();


//            newText[0] = char.ToUpper(text[0]);

//            for (int i = 0; i < newText.Length; i++)
//            {
//                if (newText[i] == '.')
//                {
//                    if (i + 2 < newText.Length)
//                    {
//                        newText[i + 2] = char.ToUpper(newText[i + 2]);
//                    }
//                }
//            }

//            return new string(newText);
//        }
//    }
//}


//Задание 2.
//Создайте приложение, проверяющее текст на недопустимые слова. 
//Если недопустимое слово найдено, оно должно быть заменено на набор символов *. 
//По итогам работы приложения необходимо показать статистику действий.

//namespace HomeWork9
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            //Console.WriteLine("Enter your text:");
//            //string? text = Console.ReadLine();
//            string text = "To be, or not to be, that is the question, Whether 'tis nobler in the mind to suffer" +
//                "The slings and arrows of die outrageous fortune, Or to take arms die against a sea of troubles," +
//                "And by opposing die end them? To die: to sleep; No more; and by die a sleep to say we end The heart-ache and the" +
//                "thousand natural shocks That flesh is heir to, 'tis a consummation die Devoutly to be wish'd. To die, to sleep";

//            string newText = NewText(text);
//            Console.WriteLine(newText);
//        }

//    public static string NewText(string text)
//        {
//            char[] newText = text.ToCharArray();

//            for (int i = 0; i < newText.Length; i++)
//            {
//                if (newText[i] == 'd' && newText[i + 1] == 'i' && newText[i + 2] == 'e')
//                {
//                    if (i < newText.Length)
//                    {
//                        newText[i] = '*';
//                        newText[i + 1] = '*';
//                        newText[i + 2] = '*';
//                    }
//                }
//            }
//            return new string(newText);
//        }
//    }
//}

//namespace HomeWork9
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            //Console.WriteLine("Enter your text:");
//            //string? text = Console.ReadLine();
//            string text = "To be, or not to be, that is the question, Whether 'tis nobler in the mind to suffer" +
//                "The slings and arrows of die outrageous fortune, Or to take arms die against a sea of troubles," +
//                "And by opposing die end them? To die: to sleep; No more; and by die a sleep to say we end The heart-ache and the" +
//                "thousand natural shocks That flesh is heir to, 'tis a consummation die Devoutly to be wish'd. To die, to sleep";

//            //Console.WriteLine("Enter forbidden word:");
//            //string? forbiddenWord = Console.ReadLine();
//            string forbiddenWord = "die";

//            string newText = NewText(text, forbiddenWord);
//            Console.WriteLine(newText);
//        }

//        public static string NewText(string text, string forbiddenWord)
//        {
//            char[] newText = text.ToCharArray();
//            int forbiddenLenght = forbiddenWord.Length;

//            for (int i = 0; i <= newText.Length - forbiddenLenght; i++)
//            {
//                if (text.Substring(i, forbiddenLenght) == forbiddenWord)
//                {
//                    for (int j = 0; j < forbiddenLenght; j++)
//                    {
//                        newText[i + j] = '*';
//                    }
//                    i += forbiddenLenght - 1;
//                }
//            }
//            return new string(newText);
//        }
//    }
//}