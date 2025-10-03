using Tyuiu.ShiganovaAV.Sprint2.Task5.V2.Lib;
namespace Tyuiu.ShiganovaAV.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
            public void Winter()
        {
            DataService ds = new DataService();
            Assert.AreEqual("зима", ds.FindMonthSeason(12));
            Assert.AreEqual("зима", ds.FindMonthSeason(1));
            Assert.AreEqual("зима", ds.FindMonthSeason(2));
        }

        [TestMethod]
        public void Spring()
        {
            DataService ds = new DataService();
            Assert.AreEqual("весна", ds.FindMonthSeason(3));
            Assert.AreEqual("весна", ds.FindMonthSeason(4));
            Assert.AreEqual("весна", ds.FindMonthSeason(5));
        }

        [TestMethod]
        public void Summer()
        {
            DataService ds = new DataService();
            Assert.AreEqual("лето", ds.FindMonthSeason(6));
            Assert.AreEqual("лето", ds.FindMonthSeason(7));
            Assert.AreEqual("лето", ds.FindMonthSeason(8));
        }

        [TestMethod]
        public void Autumn()
        {
            DataService ds = new DataService();
            Assert.AreEqual("осень", ds.FindMonthSeason(9));
            Assert.AreEqual("осень", ds.FindMonthSeason(10));
            Assert.AreEqual("осень", ds.FindMonthSeason(11));
        }
    }
}
