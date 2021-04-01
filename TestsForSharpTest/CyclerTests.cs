using System.Collections.Generic;
using CSharpTest;
using NUnit.Framework;
using SharpTest;

namespace TestsForSharpTest
{
    public class CyclerTests
    {
        [Test]
        public void FirstTest()
        {
            var list = new List<int> {1, 2, 3};
            var cycler = new Cycler<int>(list);
            
            var expected = new List<int> {1, 2, 3, 1, 2, 3, 1, 2};
            var actual = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                actual.Add(cycler.GetNext());
            }
            
            Assert.AreEqual(expected, actual);
        }
    }
}