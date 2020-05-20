using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n_pers = 10;
            double mean_pay = 4;
            double result = laba6._1.Testing.Conver(n_pers, mean_pay);
            Assert.AreEqual(40, result);
        }
    }
}
