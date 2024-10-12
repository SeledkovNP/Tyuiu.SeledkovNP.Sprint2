using Tyuiu.SeledkovNP.Sprint2.Task3.V26.Lib;
namespace Tyuiu.SeledkovNP.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        

            [TestMethod]
            public void TestMethod1()
            {
                var ds = new DataService();
                double x = 1;
                double wait = 4.702;
                double res = ds.Calculate(x);
                Assert.AreEqual(wait, res);
            }

            [TestMethod]
            public void TestMethod2()
            {
                var ds = new DataService();
                double x = 0;
                double wait = 1.667;
                double res = ds.Calculate(x);
                Assert.AreEqual(wait, res);
            }

            [TestMethod]
            public void TestMethod3()
            {
                var ds = new DataService();
                double x = -1;
                double wait = -4.754;
                double res = ds.Calculate(x);
                Assert.AreEqual(wait, res);
            }

            [TestMethod]
            public void TestMethod4()
            {
                var ds = new DataService();
                double x = -31;
                double wait = -247.968;
                double res = ds.Calculate(x);
                Assert.AreEqual(wait, res);
            }

        
    }
}