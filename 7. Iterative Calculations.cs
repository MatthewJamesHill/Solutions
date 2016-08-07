/* Find the sum of the digits of all the numbers from 1 to N (both ends included).

For N = 10 the sum is 1+2+3+4+5+6+7+8+9+(1+0) = 46

For N = 11 the sum is 1+2+3+4+5+6+7+8+9+(1+0)+(1+1) = 48

For N = 12 the sum is 1+2+3+4+5+6+7+8+9+(1+0)+(1+1) +(1+2)= 51 */


/*----------------------------------------SOLUTION----------------------------------------*/

public class Solution
{
    public static long Solution(long n)
    {
        int Result = 0;

        for (int i = 1; i <= n; i++)
        {
            int start = i;
            int finish = 0;

            while (start != 0)
            {
                finish += start % 10;
                start /= 10;
            }

            Result += finish;
        }
        return Result;
    }
}


/*----------------------------------------REFACTOR 1----------------------------------------*/

public class Refactor1
{
    public static long Solution(long n)
    {
        int Result = 0;

        for (int i = 1; i <= n; i++)
        {
            int start = i;

            while (start != 0)
            {
                Result += start % 10;
                start /= 10;
            }
        }
        return Result;
    }
}


/*----------------------------------------REFACTOR 2----------------------------------------*/

public class Refactor2
{
    public static long Solution(long n)
    {
        int Result = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int x = i; x != 0; x /= 10)
            {
                Result += x % 10;
            }
        }
        return Result;
    }
}


/*----------------------------------------REFACTOR 3----------------------------------------*/

public class Refactor3
{
    public static long Solution(long n)
    {
        int Result = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int x = i; x != 0; x /= 10)
            {
                Result += x - 10 * (x / 10);
            }
        }
        return (long)Result;
    }
}


/*----------------------------------------REFACTOR 4----------------------------------------*/

public class Refactor4
{
    public static long Solution(long n)
    {
        int Result = 0;

        if (n < 10)
        {
            for (int i = 1; i <= n; i++)
            {
                Result += i;
            }
        }

        else
        {
            Result = 45;

            for (int i = 10; i <= n; i++)
            {
                for (int x = i; x != 0; x /= 10)
                {
                    Result += x - 10 * (x / 10);
                }
            }
        }
        return (long)Result;
    }
}
