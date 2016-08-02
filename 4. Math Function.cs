/* Take int argument and return series up to nth term
 * Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + ... */


/*----------------------------------------SOLUTION----------------------------------------*/

using System;

public class Solution
{
    public static string seriesSum(int n)
    {
        if (n == 0) { return "0.00"; }

        double result = 1;

        for (int i = 1; i < n; i++)
        {
            result += 1.00 / ((i * 3.00) + 1.00);
        }

        return string.Format("{0:N2}", result);
    }
}


/*----------------------------------------REFACTOR 1----------------------------------------*/

public class Refactor1
{
    public static string seriesSum(int n)
    {
        if (n == 0) { return "0.00"; }

        double result = 1;

        for (int i = 1; i < n; i++)
        {
            result += 1.00 / ((i * 3) + 1);
        }

        return string.Format("{0:N2}", result);
    }
}
