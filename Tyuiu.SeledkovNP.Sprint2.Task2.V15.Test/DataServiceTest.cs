using Tyuiu.SeledkovNP.Sprint2.Task2.V15.Lib;
namespace Tyuiu.SeledkovNP.Sprint2.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int x = 3;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}