using Tyuiu.PopovaAA.Sprint4.Task6.V12.Lib;
namespace Tyuiu.PopovaAA.Sprint4.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            var countries = new string[] {"������", "�������", "��������", "���������", "�������", "������", "�������" };
            string[] res = ds.Calculate(countries);
            string[] wait = { "�������", "�������", "�������" };
            
            CollectionAssert.AreEqual(wait, res);
        }
    }
}