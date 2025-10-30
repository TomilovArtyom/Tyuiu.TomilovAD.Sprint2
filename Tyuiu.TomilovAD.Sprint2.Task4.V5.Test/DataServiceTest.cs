using System.Security.AccessControl;
using Tyuiu.TomilovAD.Sprint2.Task4.V5.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double wait = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
