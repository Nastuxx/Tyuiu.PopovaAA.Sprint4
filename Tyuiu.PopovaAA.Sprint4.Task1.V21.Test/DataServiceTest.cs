using Tyuiu.PopovaAA.Sprint4.Task1.V21.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMulti()
        {
            DataService ds = new DataService();

            int[] numbers = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            int res = ds.Calculate(numbers);
            int wait = 1769472;

            Assert.AreEqual(wait, res);
        }
    }
}