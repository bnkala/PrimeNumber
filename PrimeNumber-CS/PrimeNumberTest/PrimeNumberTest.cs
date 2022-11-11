
using PrimeNumberNS;

namespace PrimeNumberTest
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void TestNumberValidTrue()
        {
            PrimeNumber prime = new PrimeNumber();
            Assert.IsTrue(prime.IsNumberValid("9"));
        }

        [TestMethod]
        public void TestNumberValidFalse()
        {
            PrimeNumber prime = new PrimeNumber();
            Assert.IsFalse(prime.IsNumberValid("e"));
        }

        [TestMethod]
        public void TestNumberValidNull()
        {
            PrimeNumber prime = new PrimeNumber();
            Assert.IsFalse(prime.IsNumberValid(""));
        }

        [TestMethod]
        public void TestNumberValidOne()
        {
            PrimeNumber prime = new PrimeNumber();
            Assert.IsFalse(prime.IsNumberValid("1"));
        }

        [TestMethod]
        public void TestNumberValidZero()
        {
            PrimeNumber prime = new PrimeNumber();
            Assert.IsFalse(prime.IsNumberValid("0"));
        }

        [TestMethod]
        public void TestNumberPrime()
        {
            PrimeNumber prime = new PrimeNumber();
            string result = prime.PrimeOrNot("19");
            Assert.AreEqual("19 is a prime number", result);
        }

        [TestMethod]
        public void TestNumberNotPrime()
        {
            PrimeNumber prime = new PrimeNumber();
            string result = prime.PrimeOrNot("57");
            Assert.AreEqual("57 is not a prime number", result);
        }
    }
}