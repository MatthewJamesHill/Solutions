/* Take an integer n and two longs
 * Return the first set of two longs which:
 *     Are prime
 *     Are distance n apart
 * Else return null */

using System;
using System.Linq;

class Solution
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


/*----------------------------------------REFACTOR 1----------------------------------------*/

class Refactor1
{
    public static long[] Gap(int g, long m, long n)
    {
        long[] Result = new long[2];

        for (long i = m; i <= n; i++)
        {
            if (PrimeTool.IsPrime(i))
            {
                Result[0] = Result[1];
                Result[1] = i;

                if (Result[1] - Result[0] == g)
                {
                    return Result;
                }
            }
        }
        return null;
    }
}


/*------------------------------------------------------------------------------------------*/

// Sourced from .NET perls
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
