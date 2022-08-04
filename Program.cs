namespace Test
{
    class Task
    {
        // Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
        static void Main()
        {
            Console.WriteLine("Введите количество значений строки");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine($"Массив пустой");
            }
            else
            {
                Console.WriteLine($"Введите значение строки: {a} ");
                string[] array = new string[a];
                FillArray(array, a);
                Console.WriteLine($"Созданный массив:" + string.Join("  ", array) + " ");
                CheckArray(array);
                Console.WriteLine($"Массив строк со значениями <=3:" + string.Join(",", CheckArray(array)) + "");
            }
        }
        public static void FillArray(string[] array, int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Введите элемент строки");
                string? arraynew = Console.ReadLine();
                array[i] = arraynew;
            }
        }
        public static string[] CheckArray(string[] array)
        {
            int j = 0;
            string[] arraychecked = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    arraychecked[j] = array[i];
                    j++;
                }
            }
            return arraychecked;
        }
    }
}