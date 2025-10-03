using Tyuiu.ShiganovaAV.Sprint2.Task4.V21.Lib;
namespace Tyuiu.ShiganovaAV.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double wait = 0.943;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 1.198;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 6;
            double wait = 434.012;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 3;
            double wait = 512;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
