/* Take an integer n and two longs
 * Return the first set of two longs which:
 *     Are prime
 *     Are distance n apart
 * Else return null */


/*----------------------------------------SOLUTION----------------------------------------*/

using System;
using System.Linq;

namespace Testing
{
    class GapInPrimes
    {
        public static long[] Gap(int g, long m, long n)
        {
            long[] Result = new long[2];

            int Indexer = 0;

            for (long i = m; i <= n; i++)
            {
                if (PrimeTool.IsPrime(i))
                {
                    Result[Indexer] = i;

                    if (Result.Max() - Result.Min() == g)
                    {
                        Array.Sort(Result);
                        return Result;
                    }

                    Indexer++;
                    Indexer %= 2;
                }
            }
            return null;
        }
    }


    // Soruced from .NET perls
    public static class PrimeTool
    {
        public static bool IsPrime(long candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
