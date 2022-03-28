using NUnit.Framework;
using System.Collections.Generic;
using testsZad;

namespace SolutionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EvenOrOddReturnsEvenWhenNumberIsEvenOtherwiseFalse()
        {
            Assert.AreEqual("Even", Program.EvenOrOdd(2));
            Assert.AreEqual("Odd", Program.EvenOrOdd(1));
            Assert.AreEqual("Even", Program.EvenOrOdd(0));
            Assert.AreEqual("Odd", Program.EvenOrOdd(7));
            Assert.AreEqual("Odd", Program.EvenOrOdd(-1));
        }

        [Test]
        public static void LognestReturnsLongestSortedDistinctString()
        {
            Assert.AreEqual("aehrsty", Program.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", Program.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", Program.Longest("inmanylanguages", "theresapairoffunctions"));
        }

        [Test, Description("should fire the cannons when ready")]
        public void CannonReadyReturnsFireIfReady()
        {
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
              {"Mike", "aye"},
              {"Joe", "aye"},
              {"Johnson", "aye"},
              {"Peter", "aye"}
            };

            Assert.AreEqual("Fire!", Program.CannonsReady(gunners));
        }

        [Test, Description("should shiver me timbers if not ready")]
        public void CannonReadyReturnsShiverIfNotReady()
        {
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
              {"Mike", "aye"},
              {"Joe", "nay"},
              {"Johnson", "aye"},
              {"Peter", "aye"}
            };

            Assert.AreEqual("Shiver me timbers!", Program.CannonsReady(gunners));
        }


        [Test]
        public void BattleReturnsBiggerString()
        {
            Assert.AreEqual("Z", Program.Battle("AAA", "Z"));
            Assert.AreEqual("TWO", Program.Battle("ONE", "TWO"));
            Assert.AreEqual("Tie!", Program.Battle("ONE", "NEO"));
            Assert.AreEqual("FOUR", Program.Battle("FOUR", "FIVE"));
        }


    }
}