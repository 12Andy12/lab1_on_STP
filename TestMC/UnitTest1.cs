using Microsoft.VisualStudio.TestTools.UnitTesting;

using ModernCodingNS;


namespace TestMC
{
    
    [TestClass]
    public class UnitTest1
    {
        public ModernCoding mc = new ModernCoding();
        [TestMethod]
        public void TestFun2()
        {
            double[] a = mc.Fun2(new double[] { 0d, 1d, 2d, 3d, 4d, 5d }, 1);
            double[] b = new double[] { 1d, 2d, 3d, 4d, 5d, 0d };
            CollectionAssert.AreEqual(a, b);
            a = mc.Fun2(new double[] { 0, 1, 2, 3, 4, 5 }, 12);
            CollectionAssert.AreEqual(a, new double[] { 0, 1, 2, 3, 4, 5 });
            a = mc.Fun2(new double[] { 0, 1, 2, 3, 4, 5 }, 4);
            CollectionAssert.AreEqual(a, new double[] { 4, 5, 0, 1, 2, 3 });
        }
        [TestMethod]
        public void TestFun1()
        {
            int n = 5;
            int[] A = new int[n];
            for (int i = 0; i < A.Length; i++)
                A[i] = i;

            int[] B = new int[n];
            for (int i = 0; i < B.Length; i++)
                B[i] = B.Length - i;

            int[] C = mc.Fun1(A, B);
            CollectionAssert.AreEqual(C, new int[]{ 5, 5, 5, 5, 5 });
        }
        [TestMethod]
        public void TestFun3()
        {
            int a = mc.Fun3(new int[] { 4, 4, 5, 7, 1, 2 }, new int[] { 1, 2, 3 });
            Assert.AreEqual(a, -666);
            a = mc.Fun3(new int[] { 4, 4, 5, 7, 1, 2, 3 }, new int[] { 1, 2, 3 });
            Assert.AreEqual(a, 4);
            a = mc.Fun3(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
            Assert.AreEqual(a, 0);
            a = mc.Fun3(new int[] { 1, 1, 2, 3 }, new int[] { 1, 2, 3 });
            Assert.AreEqual(a, 1);
            a = mc.Fun3(new int[] { 1, 1, 1, 2, 3 }, new int[] { 1, 2, 3 });
            Assert.AreEqual(a, 2);
            a = mc.Fun3(new int[] { 1, 2 }, new int[] { 1, 2, 3 });
            Assert.AreEqual(a, -666);
        }
    }
}