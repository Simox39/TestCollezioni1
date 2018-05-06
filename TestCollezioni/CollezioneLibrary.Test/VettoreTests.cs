using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollezioneLibrary.Test
{
    [TestClass]
    public class VettoreTests
    {
      
        [TestMethod]
        public void TestArray1()
        {
            int[] v1 = new int[] { 3, 2, 3, 8 };
            int[] v2 = v1;
            bool sonouguali = (v1 == v2);
            Assert.AreEqual(true, sonouguali);

        }
        [TestMethod]
        public void TestArrayContenuto()
        {
            int[] v1 = new int[] { 1, 2, 3, 4 };
            int[] v2 = new int[] { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(v1, v2);

        }
        [TestMethod]
        public void TestArrayOrdinamento()
        {
            int[] v1 = new int[] { 77, 8, 13, 92 };
            int[] v2 = new int[] { 8, 13, 77, 92 };
            int[] vettoreOrdinato = Vettore.Ordina(v1);
            CollectionAssert.AreEqual(v2, vettoreOrdinato);

        }
    }
}
