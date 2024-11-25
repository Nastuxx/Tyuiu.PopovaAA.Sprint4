using Tyuiu.PopovaAA.Sprint4.Task5.V8.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                       *");
            Console.WriteLine("* Задание #5                                                                *");
            Console.WriteLine("* Вариант #8                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный          *");
            Console.WriteLine("* случайными значениями в диапазоне от -3 до 4. Заменить отрицательные      *");
            Console.WriteLine("* элементы на 0.                                                            *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] numbers = new int[rows, columns];

            Console.WriteLine("*****************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = rnd.Next(-3, 4);
                }

            }

            Console.WriteLine("\nМассив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i,j]} \t");
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            
            int[,] res = ds.Calculate(numbers);


            Console.Write(res);
            Console.ReadKey();
        }
    }
}
