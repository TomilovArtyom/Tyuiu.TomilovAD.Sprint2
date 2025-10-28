using Tyuiu.TomilovAD.Sprint2.Task0.V6.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 107;
            int y = 754;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { false, true, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
