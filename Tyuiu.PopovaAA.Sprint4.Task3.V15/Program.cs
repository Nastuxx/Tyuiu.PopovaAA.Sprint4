using Tyuiu.PopovaAA.Sprint4.Task3.V15.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] numbers = { { 7, 4, 2, 5, 3 }, { 4, 3, 2, 5, 6 }, { 6, 3, 4, 7, 5 }, { 5, 7, 4, 3, 8 }, { 7, 8, 8, 5, 6 } };

            int rows = numbers.GetUpperBound(0) + 1;
            int colums = numbers.Length / rows;

            Console.Title = "Спринт #4 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                *");
            Console.WriteLine("* Задание #3                                                                *");
            Console.WriteLine("* Вариант #15                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Подсчитайте количество     *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                       *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{numbers[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            int res = ds.Calculate(numbers);

            Console.WriteLine("Количество нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}
