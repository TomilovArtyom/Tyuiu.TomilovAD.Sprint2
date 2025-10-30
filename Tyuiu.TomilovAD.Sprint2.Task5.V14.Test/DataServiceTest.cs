using Tyuiu.TomilovAD.Sprint2.Task5.V14.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 1;
            int d = 1;
            string res = ds.FindDayName(k, d);
            string wait = "Понедельник";
            Assert.AreEqual(res, wait);
        }
    }
}
