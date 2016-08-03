/*Method to search through string 
and return a count of all lowercase characters */


/*----------------------------------------SOLUTION----------------------------------------*/

public class Program
{
    public static int LowercaseCountCheck(string str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLower(str[i])) { count++; }
        }

        return count;
    }
}


/*----------------------------------------REFACTOR 1----------------------------------------*/

public class Refactor1
{
    public static int LowercaseCountCheck(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (char.IsLower(c)) { count++; }
        }

        return count;
    }
}
