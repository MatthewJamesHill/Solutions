/* Write a function that returns true if the characters of one string
 * can be rearranged to make the word that is a second string */


/*----------------------------------------SOLUTION----------------------------------------*/
using System.Collections.Generic;


public static class Solution
{
    public static bool Scramble(string str1, string str2)
    {
        List<char> letters = new List<char>();
        foreach (char c in str1)
        {
            letters.Add(c);
        }

        foreach (char c in str2)
        {
            if (letters.Contains(c))
            {
                letters.Remove(c);
            }

            else
            {
                return false;
            }
        }

        return true;
    }
}
