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

        [TestMethod]
        public void TestAddColumnToEmptyMatrix()
        {
            // actual
            Matrix actual = new Matrix(2);
            actual.AddRow(new List<int>() { 0, 0 });
            actual.AddRow(new List<int>() { 0, 0 });

            // expected
            Matrix expected = new Matrix(0);
            expected.AddColumn(new List<int>() { 0, 0 });
            expected.AddColumn(new List<int>() { 0, 0 });

            // assert
            Assert.AreEqual(expected, actual, "Матрицы не равны.");
        }

        [TestMethod]
        public void TestAddColumn()
        {
            // actual
            Matrix actual = new Matrix(2);
            actual.AddRow(new List<int>() { 0, 0 });
            actual.AddRow(new List<int>() { 0, 0 });
            actual.AddColumn(new List<int>() { 0, 0 });

            // expected
            Matrix expected = new Matrix(3);
            expected.AddRow(new List<int>() { 0, 0, 0 });
            expected.AddRow(new List<int>() { 0, 0, 0 });

            // assert
            Assert.AreEqual(expected, actual, "Матрицы не равны.");
        }

        [TestMethod]
        public void TestMatrixIsNotEmpty()
        {
            // actual
            Matrix actual = new Matrix(2);
            actual.AddRow(new List<int>() { 1, 2 });
            actual.AddRow(new List<int>() { 3, 5 });
            actual.AddColumn(new List<int>() { 4, 7 });

            // expected
            Matrix expected = new Matrix(3);
            expected.AddRow(new List<int>() { 1, 2, 4 });
            expected.AddRow(new List<int>() { 3, 5, 7 });

            // assert
            Assert.AreEqual(expected, actual, "Матрицы не равны.");
        }
    }
}
