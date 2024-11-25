using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PopovaAA.Sprint4.Task6.V12.Lib
{
    public class DataService : ISprint4Task6V12
    {
        public string[] Calculate(string[] array)
        {
            string[] countries = Array.FindAll(array, c => c.Length == 7);
            return countries;
        }
    }
}
