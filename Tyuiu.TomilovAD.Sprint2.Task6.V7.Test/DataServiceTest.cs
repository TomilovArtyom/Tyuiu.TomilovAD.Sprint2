using Tyuiu.TomilovAD.Sprint2.Task6.V7.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int Year = 1990;
            int M = 0;
            string wait = "январь";
            string res = ds.FindMonthName(Year, M);
            Assert.AreEqual(res, wait);
        }
    }
}
