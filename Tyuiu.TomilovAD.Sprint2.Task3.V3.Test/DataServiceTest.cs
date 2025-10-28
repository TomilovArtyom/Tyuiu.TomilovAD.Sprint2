using Tyuiu.TomilovAD.Sprint2.Task3.V3.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 0;
            DataService ds = new DataService();
            double wait = 0.167;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
