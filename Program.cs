namespace Test
{
    class Task
    {
        // Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
        static void Main()
        {
            Console.WriteLine("Введите количество значений строки");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите значений строки: {a} ");
            
            string[] array = new string [a];
            FillArray(array, a);
            Console.WriteLine($"Созданный массив:"  + string.Join(",", array) + "");
            
                }
        public static void FillArray(string[] array, int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Введите строку");
                string? arraynew = Console.ReadLine();
                array[i] = arraynew;
            }
        }
        // }
        // public static void PrintArray(int[,] array)
        // {
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             Console.Write(array[i, j] + " ");
        //         }
        //         Console.WriteLine();
        //     }
        // }
        // public static void ReversArray(int[,] array, int[,] revarray)
        // {
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             revarray[j,i] = array[i,j];
                                   
        //         }
        //     }
        //     return;
        }

    }       
