using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyLib;

namespace MatrixTestApp
{
    [TestClass]
    public class TMatrix
    {
        [TestMethod]
        public void TestCreateDefaultMatrix()
        {
            // init
            int rowsCount = 3;

            // actual
            Matrix actual = new Matrix(2);
            actual.CreateDefaultMatrix(rowsCount);

            // expected
            Matrix expected = new Matrix(2);
            expected.AddRow(new List<int>() { 0, 0 });
            expected.AddRow(new List<int>() { 0, 0 });
            expected.AddRow(new List<int>() { 0, 0 });

            // assert
            Assert.AreEqual(expected, actual, "Матрицы не равны.");
        }
    }
}
