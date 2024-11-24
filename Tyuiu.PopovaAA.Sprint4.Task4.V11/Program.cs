using Tyuiu.PopovaAA.Sprint4.Task4.V11.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                               *");
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #11                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный          *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 8. Найдите сумму              *");
            Console.WriteLine("* нечетных элементов массива.                                               *");
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
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    numbers[i,j] = Convert.ToInt32(Console.ReadLine());
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

            int res = ds.Calculate(numbers);

            Console.WriteLine("Сумма нечетных элементов = " + res);
            Console.ReadKey();

        }
    }
}
