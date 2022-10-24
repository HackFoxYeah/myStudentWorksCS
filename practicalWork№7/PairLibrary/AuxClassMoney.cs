using practWork_7;
using System;

namespace PairLibrary
{
    public class Money : Pair
    {       
        public Money(in int rubles = default, in int kolecks = default)
        {
            Rubles = rubles;
            Kopecks = kolecks;
        }

        int _rubles,
           _kopecks;

        /// <summary>
        /// Возвращает количество рублей.
        /// </summary>
        public int Rubles
        {
            get => _rubles;
            private set => _rubles = value;
        }

        /// <summary>
        /// Возвращает количество копеек.
        /// </summary>
        public int Kopecks
        {
            get => _kopecks;
            private set
            {
                if(value > 99)
                {
                    throw new Exception("Kopecks can not be more than 99!");
                }
                else
                {
                    _kopecks = value;
                }
            }
        }        

        /// <summary>
        /// Производит вычитание экземпляра класса Money из текущего.
        /// </summary>
        /// <param name="moneyObj">Экземпляр класса Money.</param>
        /// <returns>Экземпляр класса Money.</returns>
        /// <exception cref="Exception">Исключение.</exception>
        public Money Subtract(in Money moneyObj)
        {
            int firstObjKopecks = Rubles * 100 + Kopecks,

               secondObjKopecks = moneyObj.Rubles * 100 + moneyObj.Kopecks,

                  resultKopecks = firstObjKopecks - secondObjKopecks;

            if (resultKopecks < 0)
            {
                throw new Exception("First money lower than second money!");
            }
            else
            {
                return new Money(resultKopecks / 100, resultKopecks % 100);
            }
        }
        
        /// <summary>
        /// Вычитает из текущего экземпляра класса Money два передаваемых.
        /// </summary>
        /// <param name="firstMoneyObj">Экземпляр класса Money.</param>
        /// <param name="secondMoneyObj">Экземпляр класса Money.</param>
        /// <returns>Экземпляр класса Money.</returns>
        /// <exception cref="Exception"></exception>
        public Money Subtract(in Money firstMoneyObj, in Money secondMoneyObj)
        {
            int firstObjKopecks = Rubles * 100 + Kopecks,

               secondObjKopecks = firstMoneyObj.Rubles * 100 + firstMoneyObj.Kopecks,

                thirdObjKopecks = secondMoneyObj.Rubles * 100 + secondMoneyObj.Kopecks,

                  resultKopecks = firstObjKopecks - secondObjKopecks - thirdObjKopecks;

            if (resultKopecks < 0)
            {
                throw new Exception("First money lower than second money!");
            }
            else
            {
                return new Money(resultKopecks / 100, resultKopecks % 100);
            }
        }

        /// <summary>
        /// Делит экземпляр класса Money на передаваемое число.
        /// </summary>
        /// <param name="value">Целое число.</param>
        /// <returns>Экземпляр класса Money.</returns>
        public Money Division(in int value)
        {
             double kopecks = Rubles * 100 + Kopecks,

                  divResult = (double)kopecks / value;

            int divResRound = (int)Math.Round(divResult);

            return new Money(divResRound / 100, divResRound % 100);
        }

        /// <summary>
        /// Увеличивает рубли и копейки на 1.
        /// </summary>
        public override void GetBigger()
        {
            _rubles++;
            _kopecks++;
        }

        public static Money operator +(in Money firstMoney, in Money secondMoney)
        {
            int rubles = firstMoney.Rubles + secondMoney.Rubles + (firstMoney.Kopecks + secondMoney.Kopecks) / 100,
               kopecks = (firstMoney.Kopecks + secondMoney.Kopecks) % 100;

            return new Money(rubles, kopecks);
        }
    }
}