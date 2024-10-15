using Tyuiu.SeledkovNP.Sprint2.Task7.V5.Lib;
namespace Tyuiu.SeledkovNP.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            double x = 0.1;
            double y = 0.1;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}