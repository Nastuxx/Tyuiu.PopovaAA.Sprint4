using Tyuiu.PopovaAA.Sprint4.Task5.V8.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] numbers = { { -3, 4, 0, 2, 1 }, { 2, 3, 4, 0, 1 }, { -3, -2, -1, 0, 1 }, { 2, 4, 0, 2, 1 }, { -3, 4, 0, -2, 1 } };

            int[,] res = ds.Calculate(numbers);
            int[,] wait = { { 0, 4, 0, 2, 1 }, { 2, 3, 4, 0, 1 }, { 0, 0, 0, 0, 1 }, { 2, 4, 0, 2, 1 }, { 0, 4, 0, 0, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}