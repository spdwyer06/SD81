using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Mick";
            bool isEqual = age == 41;

            // Equals Operator (==)
            bool isUserMe = userName == "Sean";

            // Not Equal Operator (!=)
            bool userIsNotMe = userName != "Sean";

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine($"The lists are equal: {listsAreEqual}");

            // Greater Than Operator (>)
            bool isGreaterThan = age > 12;

            // Greater Than Or Equal To Operator (>=)
            bool isGreaterThanOrEqualTo = age >= 21;

            // Less Than Operator (<)
            bool isLessThan = age < 12;

            // Less Than Or Equal To Operator (<=)
            bool isLessThanOrEqualTo = age <= 21;

            // Or Operator (||)
            bool orValue = isGreaterThan || isGreaterThanOrEqualTo;

            // And Operator (&&)
            bool andValue = isLessThan && isLessThanOrEqualTo;
        }
    }
}
