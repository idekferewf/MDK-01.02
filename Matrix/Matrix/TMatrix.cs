using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyLib;

namespace MatrixTestApp
{
    [TestClass]
    public class TMatrix
    {
        public Matrix GetTestMatrix()
        {
            // 1, 2, 8, 9
            // 3, 5, 19, 5
            // 10, 23, 1, 7

            Matrix matrix = new Matrix(2);
            matrix.AddRow(new List<int>() { 1, 2 });
            matrix.AddRow(new List<int>() { 3, 5 });
            matrix.AddRow(new List<int>() { 10, 23 });
            matrix.AddColumn(new List<int>() { 8, 19, 1 });
            matrix.AddColumn(new List<int>() { 9, 5, 7 });

            return matrix;
        }

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

        [TestMethod]
        [DataRow(1, 0, 3)]
        [DataRow(3, 1, null)]
        [DataRow(0, 4, null)]
        [DataRow(10, 10, null)]
        public void TGetCell(int rowIndex, int columnIndex, object expected)
        {
            // init
            Matrix matrix = GetTestMatrix();

            // actual
            object cell = matrix.GetCell(rowIndex, columnIndex);

            // assert
            Assert.AreEqual(expected, cell);
        }
    }
}
