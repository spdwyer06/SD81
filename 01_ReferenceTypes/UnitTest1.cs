using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;

            string declared;
            declared = "This is initialized.";

            string declareAndInitialize = "This is both declared and initialized.";

            string firstName = "Sean";
            string lastName = "Dwyer";

            string interpolatedFullName = $"{firstName} {lastName}";
            string concatenatedFullName = firstName + " " + lastName;
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", stringExample };

            string firstItem = stringArray[0];
            string secondItem = stringArray[1];
            string thirdItem = stringArray[2];

            Console.WriteLine(firstItem);
            Console.WriteLine(secondItem);
            Console.WriteLine(thirdItem);

            stringArray[0] = "Hey there";

            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();
            List<string> initializedList = new List<string> { "Hello", "World" };
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("Hi");
            listOfStrings.AddRange(new List<string> { "Sean", "Dwyer" });

            foreach (var item in listOfStrings)
            {
                Console.Write($"{item} ");
            }

            // Just used to separate lines in test results
            Console.WriteLine();

            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("First Queue Item");
            firstInFirstOut.Enqueue("Second Queue Item");
            firstInFirstOut.Enqueue("Third Queue Item");

            string firstQueueItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstQueueItem);

            string nextItem = firstInFirstOut.Peek();
            Console.WriteLine(nextItem);

            //while (firstInFirstOut.Count != 0)
            //{
            //    string queueItem = firstInFirstOut.Dequeue();
            //    Console.WriteLine(queueItem);
            //}

            Dictionary<int, string> keyValuePair = new Dictionary<int, string>();

            keyValuePair.Add(3, "First Dictionary Item");
            keyValuePair.Add(9, "Second Dictionary Value");
            keyValuePair.Add(13, "Third Dictionary Value");

            string firstDictItem = keyValuePair[3];
            string secondDictItem = keyValuePair[9];
            string thirdDictItem = keyValuePair[13];

            Console.WriteLine(firstDictItem);

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);
        }
    }
}
