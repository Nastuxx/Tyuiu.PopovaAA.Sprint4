using Tyuiu.PopovaAA.Sprint4.Task6.V12.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Класс Array                                                         *");
            Console.WriteLine("* Задание #6                                                                *");
            Console.WriteLine("* Вариант #12                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан строковый массив данных [Россия, Украина, Беларусь,Казахстан,Молдова, *");
            Console.WriteLine("* Латвия, Эстония], используя класс Array, выведите элементы массива,       *");
            Console.WriteLine("* длина которых равна 7 символам.                                           *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            var countries = new string[] { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine(countries[i]);
            }


            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            string[] res = ds.Calculate(countries);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
