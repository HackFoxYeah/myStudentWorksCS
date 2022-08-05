using System.Data;

namespace _21ая_работа
{
    static class VisualArray
    {
        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            DataTable result = new DataTable();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                result.Columns.Add("СТЦ" + (i + 1), typeof(T));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = result.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                result.Rows.Add(row);
            }

            return result;
        }
    }
}
