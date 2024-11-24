using Tyuiu.PopovaAA.Sprint4.Task4.V11.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSum()
        {
            DataService ds = new DataService();

            int[,] numbers = { { 5, 7, 7, 8, 5}, {6, 5, 6, 8, 6 }, { 7, 6, 8, 8, 5}, { 7, 6, 7, 8, 6}, { 7, 6, 7, 7, 5} };
            int res = 81;
            int wait = ds.Calculate(numbers);

            Assert.AreEqual(wait, res);
        }
    }
}