using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'x';
            char symbol = '!';
            char numbers = '9';
            char space = ' ';
            char specialCharacter = '\n';
            //char newChar = "y";
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte maxByteSize = 255;
            sbyte max_sByteSize = 127;
            short maxShortSize = 32767;
            Int16 anotherShortExample = 32000;
            int maxIntSize = 2147483647;
            long maxLongSize = 9223372036854775807;
        }

        [TestMethod]
        public void Decimals()
        {
            float maxFloatSize = 1.045231f;
            double maxDoubleSize = 1.789053278907036d;
            decimal maxDecimalSize = 1.2578907289045789789789789787897m;

            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);
        }

        enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Croissant };

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherPastry = PastryType.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1992, 01, 03);
        }
    }
}
