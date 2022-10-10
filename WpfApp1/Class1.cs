using System;

namespace WpfApp1
{
    internal class Class1
    {
        /// <summary>
        /// Метод проверяет число на чётность.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEven(int value)
        {
            if (value % 2 == 0) return true;
            else return false;            
        }


        
    }
}
