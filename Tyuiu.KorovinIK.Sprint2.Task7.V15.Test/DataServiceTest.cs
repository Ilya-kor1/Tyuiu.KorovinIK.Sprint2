using Tyuiu.KorovinIK.Sprint2.Task7.V15.Lib;
namespace Tyuiu.KorovinIK.Sprint2.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool weit = true;

            Assert.AreEqual(weit, res);
        }
    }
}
