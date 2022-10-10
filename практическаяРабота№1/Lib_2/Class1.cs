using System;

namespace Lib_2
{
    public class Lib
    {
        static public string RandNumsK(int firstInd, int secondInd, int k, out int sum, out int kol)
        {
            string numbers = "1";
            sum = 0;
            kol = 0;
            int temp;

            if (k > 0 || k == 0) // проверка адекватности введённого k ( k < 0)
            {
                return "";
            }

            Random rnd = new Random();

            while (sum > k && sum != k) // работа функции 
            {
                temp = rnd.Next(firstInd, secondInd);
                numbers = String.Concat(numbers, " ", temp);
                sum -= temp;
                kol++;
            }

            return numbers;
        }
    }
}
