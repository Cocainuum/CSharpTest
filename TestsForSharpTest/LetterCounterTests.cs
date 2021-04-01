using System.Collections;
using System.Collections.Generic;
using CSharpTest;
using NUnit.Framework;

namespace TestsForSharpTest
{
    public class LetterCounterTests
    {
        [Test]
        public void FirstTest()
        {
            var testString = "t5qr33d56q3";

            var expected = new Dictionary<char, int>
            {
                {'5', 2},
                {'3', 3},
                {'6', 1}
            };
            Assert.AreEqual(expected, testString.CountNumbers());
        }
        
        [Test]
        public void SecondTest()
        {
            var testString = ";f2*14'2444";

            var expected = new Dictionary<char, int>
            {
                {'2', 2},
                {'1', 1},
                {'4', 4}
            };
            Assert.AreEqual(expected, testString.CountNumbers());
        }
    }
}