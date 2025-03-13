using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;

namespace MyLib
{
    public class Matrix
    {
        public List<List<int>> matrix_ = new List<List<int>>();
        public int columnSize_;

        public Matrix(int columnSize)
        {
            columnSize_ = columnSize;
        }

        public void CreateDefaultMatrix(int rowsCount)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < columnSize_; j++)
                {
                    row.Add(0);
                }
                matrix_.Add(row);
            }
        }

        public void AddRow(List<int> row)
        {
            if (row.Count == columnSize_)
            {
                matrix_.Add(row);
            }
            else if (row.Count < columnSize_)
            {
                List<int> row_ = new List<int>(row);
                for (int i = 0; i < columnSize_ - row_.Count; i++)
                {
                    row_.Add(0);
                }
                matrix_.Add(row_);
            }
            else
            {
                List<int> row_ = row.Take(columnSize_).ToList();
                matrix_.Add(row_);
            }
        }

        public void AddColumn(List<int> column)
        {
            List<int> column_ = new List<int>(column);
            if (matrix_.Count == 0)
            {
                for (int i = 0; i < column_.Count; i++)
                {
                    matrix_.Add(new List<int>() { });
                    matrix_[i].Add(column_[i]);
                }
            }
            else
            {
                if (column_.Count > matrix_.Count)
                {
                    column_ = column_.Take(matrix_.Count).ToList();
                }
                else if (column_.Count < matrix_.Count)
                {
                    for (int i = 0; i < matrix_.Count - column_.Count; i++)
                    {
                        column_.Add(0);
                    }
                }

                // добавляем колонку
                for (int i = 0; i < matrix_.Count; i++)
                {
                    matrix_[i].Add(column_[i]);
                }
            }
            columnSize_ += 1;
        }

        public object GetCell(int rowIndex, int columnIndex)
        {
            object cell;
            try
            {
                cell = matrix_[rowIndex][columnIndex];
            } catch (Exception e)
            {
                cell = null;
            }
            return cell;
        }

        public override bool Equals(object obj)
        {
            // проверка на null
            if (obj == null)
            {
                return false;
            }

            // проверка на соответствие типов
            if (obj.GetType() != typeof(Matrix))
            {
                return false;
            }

            Matrix obj_ = (Matrix)obj;

            // сравниваем количество строк
            if (obj_.matrix_.Count != matrix_.Count)
            {
                return false;
            }

            // сравниваем элементы строк
            for (int i = 0; i < matrix_.Count; i++)
            {
                for (int j = 0; j < matrix_[i].Count; j++)
                {
                    if (matrix_[i][j] != obj_.matrix_[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hash = 0;
            foreach (var row in matrix_)
            {
                foreach (var element in row)
                {
                    hash = +element.GetHashCode();
                }
            }
            return hash;
        }
    }
}
