namespace Lib2
{    
    public class Library2
    {
        /// <summary>
        /// Метод находит произведение всех элементов одномерного массива.
        /// </summary>
        /// <param name="array">Массив, в котором нужно найти произведение всех элементов.</param>
        /// <returns>Произведение элементов массива.</returns>
        public static int GetMulti(int[] array)
        {
            int multy = 1;

            foreach (int i in array)
            {
                multy *= i;
            }

            return multy;
        }
    }
}