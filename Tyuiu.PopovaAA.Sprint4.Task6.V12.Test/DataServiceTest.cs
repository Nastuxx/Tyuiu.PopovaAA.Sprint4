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
            var countries = new string[] {"Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            string[] res = ds.Calculate(countries);
            string[] wait = { "Украина", "Молдова", "Эстония" };
            
            CollectionAssert.AreEqual(wait, res);
        }
    }
}