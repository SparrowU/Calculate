using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculate
{
    [TestClass]
    public class UnitTest1
    {
        Calc calc = new Calc();

        [TestMethod]
        public void TestMethod_sum1()
        {
            int test_sum = calc.sum(3, 4);
            Assert.AreEqual(7, test_sum);
        }
        [TestMethod]
        public void TestMethod_sum2()
        {
            int test_sum = calc.sum(6, 4);
            Assert.AreEqual(10, test_sum);
        }
        [TestMethod]
        public void TestMethod_sum3()
        {
            int test_sum = calc.sum(30, 4);
            Assert.AreEqual(33, test_sum);
        }
        [TestMethod]
        public void TestMethod_pow1()
        {
            int test_pow = calc.pow(4);
            Assert.AreEqual(16, test_pow);

        }
        [TestMethod]
        public void TestMethod_pow2()
        {
            int test_pow = calc.pow(2);
            Assert.AreEqual(5, test_pow);
        }
        [TestMethod]
        public void TestMethod_pow3()
        {
            int test_pow = calc.pow(3);
            Assert.AreEqual(9, test_pow);
        }
        [TestMethod]
        public void square_root_test1()
        {
            double test_square_root = calc.square_root(9);
            Assert.AreEqual(3, test_square_root);
        }
        [TestMethod]
        public void square_root_test2()
        {
            double test_square_root = calc.square_root(223);
            Assert.AreEqual(35, test_square_root);
        }
        [TestMethod]
        public void square_root_test3()
        {
            double test_square_root = calc.square_root(16);
            Assert.AreEqual(4, test_square_root);
        }
    }
}
