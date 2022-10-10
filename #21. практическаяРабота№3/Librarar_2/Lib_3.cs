namespace Lib2
{
    public class Library3
    {
        /// <summary>
        /// Дана матрица размера M × N и целое число K (1 ≤ K ≤ N).
        /// Найти сумму и произведение элементов K-го столбца данной матрицы.
        /// </summary>
        /// <param name="array">Массив, в котором нужно найти произведение всех элементов.</param>
        /// <returns>Произведение элементов массива.</returns>
        public static void SumNMulty(int[,] array, int k, out int sum, out int multy)
        {
            multy = 1;
            sum = 0;

            if (1 <= k && k <= array.GetLength(1))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum += array[i, k - 1];
                    multy *= array[i, k - 1];
                }
            }
        }
    }
}