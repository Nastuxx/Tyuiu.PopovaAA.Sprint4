using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PopovaAA.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] numbers = new int[n, m];

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    numbers[i,j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }

            int count = 1;

            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (numbers[i,j] % 2 == 0)
                    {
                        count *= numbers[i,j];
                    }
                }
            }

            return count;
        }
    }
}
