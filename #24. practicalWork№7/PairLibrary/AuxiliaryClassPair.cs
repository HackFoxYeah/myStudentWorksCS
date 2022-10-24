﻿namespace practWork_7
{
    public class Pair
    {
        double _first,
               _second;

        public Pair()
        {
            _first = default;
            _second = default;
        }

        public Pair(double first, double second)
        {
            _second = second;
            _first = first;
        }

        /// <summary>
        /// Содержит первое число.
        /// </summary>
        public double FirstValue
        {
            get { return _first; }
            set { _first = value; }
        }

        /// <summary>
        /// Содержит второе число.
        /// </summary>
        public double SecondValue
        {
            set { _second = value; }
            get { return _second; }
        }

        /// <summary>
        /// Складывать две пары чисел.
        /// </summary>
        /// <param name="firstObj">Объект класса Pair.</param>
        /// <param name="secondObj">Объект класса Pair.</param>
        /// <returns>Объект класса Pair.</returns>
        public static Pair Add(Pair firstObj, Pair secondObj)
        {
            return new Pair(firstObj.FirstValue + secondObj.FirstValue,
                            firstObj.SecondValue + secondObj.SecondValue);
        }

        /// <summary>
        /// Складывает две пары чисел.
        /// </summary>
        /// <param name="secondObj">Объект класса Pair.</param>
        /// <returns>Объект класса Pair.</returns>
        public Pair Add(Pair secondObj)
        {
            return new Pair(_first + secondObj.FirstValue,
                            _second + secondObj.SecondValue);
        }

        /// <summary>
        /// Cкладывает три пары чисел.
        /// </summary>
        /// <param name="firstObj">Объект класса Pair.</param>
        /// <param name="secondObj">Объект класса Pair.</param>
        /// <param name="thirdObj">Объект класса Pair.</param>
        /// <returns>Объект класса Pair.</returns>
        public static Pair Add(Pair firstObj, Pair secondObj, Pair thirdObj)
        {
            return new Pair(firstObj.FirstValue + secondObj.FirstValue + thirdObj.FirstValue,
                            firstObj.SecondValue + secondObj.SecondValue + thirdObj.SecondValue);
        }

        /// <summary>
        /// Увеличивает поля объекта на 1.
        /// </summary>
        public void GetBigger()
        {
            _first++;
            _second++;
        }

        /// <summary>
        /// Складывает пару чисел.
        /// </summary>
        /// <returns>Целое число.</returns>
        public double SumOfPair() => _first + _second;

        /// <summary>
        /// Уменьшивает поля объекта на 1.
        /// </summary>
        public void GetSmaller()
        {
            _first--;
            _second--;
        }

        public static Pair operator +(Pair first, Pair second)
        {
            return new Pair(first.FirstValue + second.FirstValue, first.SecondValue + second.SecondValue);
        }

        public static Pair operator --(Pair first)
        {
            return new Pair(first.FirstValue--, first.SecondValue--);
        }
    }
}