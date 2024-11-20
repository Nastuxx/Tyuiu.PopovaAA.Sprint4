using Tyuiu.PopovaAA.Sprint4.Task0.V19.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                               *");
            Console.WriteLine("* Задание #0                                                                *");
            Console.WriteLine("* Вариант #19                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать произведение    *");
            Console.WriteLine("* нечетных элементов массива.  {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}               *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int[] numbers = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetMultOddArrEl(numbers);

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Результат: " + ds.GetMultOddArrEl(numbers));

            
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
