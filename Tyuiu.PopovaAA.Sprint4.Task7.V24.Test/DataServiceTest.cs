using Tyuiu.PopovaAA.Sprint4.Task7.V24.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int rows = 5;
            int columns = 3;
            string str = "651827384219648";
            int[,] numbers = new int[rows, columns];

            int res = ds.Calculate(rows, columns, str);
            int wait = 1179648;

            Assert.AreEqual(wait, res);
        }
    }
}