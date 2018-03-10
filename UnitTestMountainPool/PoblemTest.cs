using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mountainPool;

namespace UnitTestMountainPool
{
    [TestClass]
    public class PoblemTest
    {
        #region Water fill test
        [TestMethod()]
        [TestCategory("Water fill")]
        public void FillPoolTest1()
        {
            int[] landHeight = new int[] { 5, 2, 3, 4, 5, 4, 1, 3, 1 };
            var prb = new Problem();
            Assert.AreEqual(8,prb.Solve(landHeight));
        }

        [TestMethod()]
        [TestCategory("Water fill")]
        public void FillPoolTest2()
        {
            int[] landHeight = new int[] { 2, 1, 5, 4, 3, 2, 1, 5 };
            var prb = new Problem();
            Assert.AreEqual(11,prb.Solve(landHeight));
        }

        [TestMethod()]
        [TestCategory("Water fill")]
        public void FillPoolTest3()
        {
            int[] landHeight = new int[] { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };
            var prb = new Problem();
            Assert.AreEqual(0, prb.Solve(landHeight));
        }

        [TestMethod()]
        [TestCategory("Water fill")]
        public void FillPoolTest4()
        {
            int[] landHeight = new int[] { 2, 3, 4, 0, 7, 1, 7 };
            var prb = new Problem();
            Assert.AreEqual(10, prb.Solve(landHeight));
        }

        [TestMethod()]
        [TestCategory("Water fill")]
        public void FillPoolTest5()
        {
            int[] landHeight = new int[] { 7, 1, 3, 2 };
            var prb = new Problem();
            Assert.AreEqual(2, prb.Solve(landHeight));
        }

        
        #endregion
        #region Speed
        [TestMethod()]
        [TestCategory("Stress test")]
        public void StressTest()
        {
            int [] landscape = new int[32000];
            Random rnd = new Random();
            for (int i = 0; i < landscape.Length; i++)
            {
                landscape[i] = rnd.Next(0, 32000);
            }
            var prb = new Problem();
            prb.Solve(landscape);
        }
        #endregion
        #region Exception test
        [TestMethod()]
        [TestCategory("Exception")]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionHeightTest()
        {
            int[] landHeight = new int[] { 7, 35000, 3, 2 };
            var prb = new Problem();
            prb.Solve(landHeight);
        }

        [TestMethod()]
        [TestCategory("Exception")]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionLengthTest()
        {
            int[] landHeight = new int[35000];
            var prb = new Problem();
            prb.Solve(landHeight);
        }

        [TestMethod()]
        [TestCategory("Exception")]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionEmptyTest()
        {
            int[] landHeight = new int[] { };
            var prb = new Problem();
            prb.Solve(landHeight);
        }
        #endregion


    }
}
