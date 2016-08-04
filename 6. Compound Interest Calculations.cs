/* A person wishes to sell their old car and buy a new one
 * They can save x amount per month, however:
 *     Their old car depreciates by n% per month
 *     The new car depreciates by n%
 *     The rate of depreciation increases by 0.5% per 2 months
 *     
 * Return how many months it will take them to save, and how much they will have left over */


/*----------------------------------------SOLUTION----------------------------------------*/

using System;

public class Solution
{
    public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth)
    {
        int[] Result = new int[] { 0, startPriceOld - startPriceNew };

        decimal oldCarValue = startPriceOld;
        decimal newCarValue = startPriceNew;

        int savings = 0;
        decimal percentLoss = Convert.ToDecimal(percentLossByMonth);


        for (int months = 1; newCarValue > (oldCarValue + savings); months++)
        {
            Result[0] = months;

            if (months % 2 == 0) { percentLoss += 0.5m; }

            oldCarValue -= (oldCarValue / 100) * percentLoss;
            newCarValue -= (newCarValue / 100) * percentLoss;
            savings += savingperMonth;
                
            Result[1] = Convert.ToInt32((oldCarValue + savings) - newCarValue);
        }

        return Result;
    }
}
