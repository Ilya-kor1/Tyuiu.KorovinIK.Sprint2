using Tyuiu.KorovinIK.Sprint2.Task4.V25.Lib;
namespace Tyuiu.KorovinIK.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 9;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -200;
            double res = ds.Calculate(x, y);
            double wait = -200.010;
            Assert.AreEqual(wait, res);
        }
    }
}
