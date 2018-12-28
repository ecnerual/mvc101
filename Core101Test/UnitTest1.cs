using core101.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core101Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int[] t = new[] {1, 2, 3, 4};

            //act
            int sum = MathHelper.ArraySum(t);
            
            //assert
            Assert.AreEqual(10, sum);
        }
    }
}
