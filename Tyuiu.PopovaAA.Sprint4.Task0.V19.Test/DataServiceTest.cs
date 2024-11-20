using Tyuiu.PopovaAA.Sprint4.Task0.V19.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numbers = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetMultOddArrEl(numbers);
            int wait = 297675;

            Assert.AreEqual(wait, res);
        }
    }
}