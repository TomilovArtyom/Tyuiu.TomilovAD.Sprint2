using Tyuiu.TomilovAD.Sprint2.Task1.V16.Lib;

namespace Tyuiu.TomilovAD.Sprint2.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
