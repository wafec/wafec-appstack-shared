using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wafec.AppStack.Shared.Lang;

namespace Wafec.AppStack.Shared.LangTests
{
    [TestClass]
    public class UtilityTests
    {
        [TestMethod]
        public void TestTrueIfThrows()
        {
            var result = Utility.TrueIfThrows<MyCustomException>(() =>
            {
                throw new MyCustomException();
            });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTrueIfThrowsWithInvalidException()
        {
            Assert.ThrowsException<OtherCustomException>(() =>
            {
                var result = Utility.TrueIfThrows<MyCustomException>(() =>
                {
                    throw new OtherCustomException();
                });
            });
        }

        [TestMethod]
        public void TestTrueIfThrowsWhenNotThrown()
        {
            var result = Utility.TrueIfThrows<MyCustomException>(() =>
            {

            });
            Assert.IsFalse(result);
        }
    }
}
