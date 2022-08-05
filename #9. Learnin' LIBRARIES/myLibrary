namespace Библиотека_для_15ой_работы
{
    public class ClassOne
    {
        public static int compareNumbers(int inptValue1)
        {
            if ((inptValue1 / 10) > (inptValue1 % 10)) return 1; //первая больше второй         
            else if ((inptValue1 % 10) > (inptValue1 / 10)) return 2; //вторая больше первой      
            else return 3; //они равны          
        }

        public static int areNumbersEqual(int inptValue1)
        {
            if ((inptValue1 / 10) == (inptValue1 % 10)) return 1; //цифры равны         
            else return 0; //цифры не равны                   
        }

        public static int sumMultipleOf3(int inptValue2)
        {
            int sum = 0;

            while (inptValue2 != 0)
            {
                int x = inptValue2 % 10;

                sum += x;

                inptValue2 = inptValue2 / 10;
            }

            if (sum % 3 == 0) return 1; //сумма цифр кратна 3
            else return 0; //сумма цифр не кратна 3           
        }


    }
}

