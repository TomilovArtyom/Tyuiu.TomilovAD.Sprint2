using Tyuiu.TomilovAD.Sprint2.Task7.V4.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.3;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
