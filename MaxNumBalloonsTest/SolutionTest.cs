using LeetCodeMaxNumberOfBalloons;
using NUnit.Framework;

namespace MaxNumBalloonsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //nlaebolko output 1
        [Test]
        public void Test1()
        {
            string balloonString = "nlaebolko";
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(balloonString);
            Assert.AreEqual(1, result);
        }

        //loonbalxballpoon   output 2
        [Test]
        public void Test2()
        {
            string balloonString = "loonbalxballpoon";
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(balloonString);
            Assert.AreEqual(2, result);
        }
        //leetcode  output 0
        [Test]
        public void Test3()
        {
            string balloonString = "leetcode";
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(balloonString);
            Assert.AreEqual(0, result);
        }
    }
}