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
            Assert.AreEqual("Зима", ds.FindMonthSeason(12));
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Зима", ds.FindMonthSeason(2));
        }

        [TestMethod]
        public void Spring()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Весна", ds.FindMonthSeason(3));
            Assert.AreEqual("Весна", ds.FindMonthSeason(4));
            Assert.AreEqual("Весна", ds.FindMonthSeason(5));
        }

        [TestMethod]
        public void Summer()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Лето", ds.FindMonthSeason(6));
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));
            Assert.AreEqual("Лето", ds.FindMonthSeason(8));
        }

        [TestMethod]
        public void Autumn()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Осень", ds.FindMonthSeason(9));
            Assert.AreEqual("Осень", ds.FindMonthSeason(10));
            Assert.AreEqual("Осень", ds.FindMonthSeason(11));
        }
    }
}
