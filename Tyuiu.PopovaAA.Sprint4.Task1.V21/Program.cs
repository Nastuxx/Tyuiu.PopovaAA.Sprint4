using Tyuiu.PopovaAA.Sprint4.Task1.V21.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                              *");
            Console.WriteLine("* Задание #1                                                                *");
            Console.WriteLine("* Вариант #21                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов, заполненный          *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8. Подсчитать произведение    *");
            Console.WriteLine("* четных элементов массива.  {2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6}              *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            int res = ds.Calculate(numbers);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
