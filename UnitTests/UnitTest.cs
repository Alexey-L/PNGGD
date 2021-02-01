namespace UnitTests
{
    using NUnit.Framework;

    public class UnitTest
    {
        [Test]
        public void TestDoubleSum()
        {
            const int x1 = 6;
            const int x2 = 7;
            const int expRes = 13;

            Features ef = new Features();
            Assert.AreEqual(expRes, ef.xSum(x1, x2));
        }

        [Test]
        public void TestMultipleSum1()
        {
            const int x1 = 10;
            const int x2 = 5;
            const int x3 = 5;
            const int x4 = 5;
            const int x5 = 5;
            const int expRes = 25;

            Features ef = new Features();
            Assert.AreEqual(expRes, ef.xSum(x1, x2, x3, x4, x5), "‘се пропало");
        }

        [Test]
        public void TestMultipleSum2()
        {
            const int x1 = 6;
            const int expRes = 6;

            Features ef = new Features();
            Assert.AreEqual(expRes, ef.xSum(x1));
        }

        [Test]
        public void TestTripleSum()
        {
            const int x1 = 6;
            const int x2 = 7;
            const int x3 = 2;
            const int expRes = 15;

            Features ef = new Features();
            Assert.AreEqual(expRes, ef.xSum(x1, x2, x3));
        }

        [Test]
        public void TestMultipleAssert()
        {
            Features ef = new Features();

            Assert.Multiple(() =>
            {
                Assert.That(15.Equals(ef.xSum(5, 5, 5)), "Assert message #1");
                Assert.That(100.Equals(ef.xSum(33, 33, 34)), "Assert message #2");
                Assert.AreNotEqual(100.Equals(ef.xSum(33, 33, 34)), "Assert message #3");
            });
        }

        [Test]
        public void TestDoubleStringSum()
        {
            Features ef = new Features();

            Assert.That(ef.xSum("10", "101"), Does.Not.Contain("0"), "Assert message #4");
            Assert.That("Some Text", Does.Not.Contain("www"), "Assert message #5");
        }
    }
}
