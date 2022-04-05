using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CNTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var cn1 = new ComplexNumber.ComplexNumber(2, 3);
            var cn2 = new ComplexNumber.ComplexNumber(5, -7);

            Assert.AreEqual(cn1+cn2, new ComplexNumber.ComplexNumber(31,1));

        }
    }
}
