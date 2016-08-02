// Take int arguments and return grade based on mean of arguments


/*----------------------------------------SOLUTION----------------------------------------*/

using System;

public class Solution
{
  public static char GetGrade(int s1, int s2, int s3)
  {
    int mean = (s1 + s2 + s3)/3;
    
    if (mean < 60) { return 'F'; }
    else if (mean < 70) { return 'D'; }
    else if (mean < 80) { return 'C'; }
    else if (mean < 90) { return 'B'; }
    else { return 'A'; }
  }
}
