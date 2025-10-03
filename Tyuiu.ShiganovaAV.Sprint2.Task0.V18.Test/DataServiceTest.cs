using Tyuiu.ShiganovaAV.Sprint2.Task0.V18.Lib;
namespace Tyuiu.ShiganovaAV.Sprint2.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperation()
        {
             DataService ds = new DataService();
            int x = 5105;
            int y = 475;
            bool[]res=new bool[6];
            bool[] wait = new bool [6] { false, true, true, true, true, false };
             res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
