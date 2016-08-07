/* Take an integer n seconds and return a string of the hours, minutes, and seconds of n.
 * n will never be greater than 359,999 */


/*----------------------------------------SOLUTION----------------------------------------*/
using System;

public static class Solution
{
    public static string GetReadableTime(int secondsIn)
    {
        int seconds = secondsIn;
        int minutes = 0;
        int hours = 0;

        if (seconds / 3600 > 0)
        {
            hours = seconds / 3600;
            seconds -= hours * 3600;
        }

        if (seconds / 60 > 0)
        {
            minutes = seconds / 60;
            seconds -= minutes * 60;
        }

        return hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}


/*----------------------------------------Refactor 1----------------------------------------*/
public static class Refactor2
{
    public static string GetReadableTime(int secondsIn)
    {
        TimeSpan time = TimeSpan.FromSeconds(secondsIn);

        return string.Format("{0:00}:{1:00}:{2:00}", (int)time.TotalHours, time.Minutes, time.Seconds);
    }
}


/*----------------------------------------Refactor 2----------------------------------------*/
public static class Refactor1
{
    public static string GetReadableTime(int secondsIn)
    {
        int seconds = secondsIn;
        int hours = seconds / 3600;
        seconds %= 3600;

        int minutes = seconds / 60;
        seconds %= 60;

        return hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
