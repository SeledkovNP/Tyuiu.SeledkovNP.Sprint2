using Tyuiu.SeledkovNP.Sprint2.Task5.V8.Lib;
namespace Tyuiu.SeledkovNP.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int m = 1;
            int n = 2;
            string res = ds.FindDateOfPreviousDay(m, n);
            string wait = "1";
            Assert.AreEqual(wait, res);
        }
    }
}