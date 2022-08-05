using System;

namespace Работа_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i=1; i<=300; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    if (i%j==0)
                    {
                        count = count++;
                    }
                }

                if (count == 5)
                {
                    Console.WriteLine(i);
                }

                Console.ReadKey();
            }
        }
    }
}
