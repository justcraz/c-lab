using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(CoderTask.csharpExercise.firstNum(357), 3);
            Assert.AreEqual(CoderTask.csharpExercise.lastNum(357, 0), 7);

        }
    }
}