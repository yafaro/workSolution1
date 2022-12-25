using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// 判斷質數
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool Isprime(int number)
        {
            int a = (int)Math.Sqrt(number);
            if (number <= 2 || number % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i <= a; i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
    

