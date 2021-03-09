using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);


            TimeSpan timeSpan = now - someDay;
        }
    }
}
