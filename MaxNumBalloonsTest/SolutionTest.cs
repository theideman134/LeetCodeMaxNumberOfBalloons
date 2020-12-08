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

        [Test]
        public void Test4()
        {
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(string.Empty);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test5()
        {
 
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(null);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test6()
        {
            string balloonString = "bballoon";
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(balloonString);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Test7()
        {
            string balloonString = "bbaallllloooonn";
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(balloonString);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Test8()
        {
            string balloonString = "bbbaaallllloooooonnn";
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(balloonString);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Test9()
        {
            string balloonString = "bbbaaallllllloooooonnn";
            var solution = new Solution();
            var result = solution.MaxNumberOfBalloons(balloonString);
            Assert.AreEqual(3, result);
        }
    }
}