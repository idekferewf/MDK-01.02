using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyLib;

namespace MatrixTestApp
{
    [TestClass]
    public class TMatrix
    {
        [TestMethod]
        public void TCreateDefaultMatrix()
        {
            // init
            int columnSize = 2;
            int rowSize = 2;

            // actual
            Matrix matrix = new Matrix();
            List<List<int>> actual = matrix.CreateDefaultMatrix(columnSize, rowSize);

            // expected
            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>() { 0, 0 },
                new List<int>() { 0, 0 }
            };

            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
