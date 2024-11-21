using Tyuiu.PopovaAA.Sprint4.Task2.V14.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                      *");
            Console.WriteLine("* Задание #2                                                                *");
            Console.WriteLine("* Вариант #14                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный          *");
            Console.WriteLine("* случайными значениями в диапазоне от 1 до 8. Подсчитать произведение      *");
            Console.WriteLine("* нечетных элементов массива.                                               *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            
            int[] numbers = new int[len];
            for (int i = 0; i < len; i++)
            {
                numbers[i] = rnd.Next(1, 8);
            }

            Console.WriteLine("Массив: ");

            for (int i = 0;i < len; i++)
            {
                Console.Write(numbers[i] + "\t");
            }

            Console.WriteLine();

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            int res = ds.Calculate(numbers);
            Console.WriteLine("Произведение нечетных элементов: " + res);
            Console.ReadKey();
        }
    }
}
