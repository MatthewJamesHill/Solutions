/*Simple method to search through an array to find an index
where the sum of all items to the left of the index
and the sum of all items to the right of the index are equal,
otherwise to return -1. */


/*----------------------------------------SOLUTION----------------------------------------*/

using System.Linq;

public class Solution
{
  public static int FindEvenIndex(int[] arr)
  {
    for (int index = 0; index < arr.Length; index++)
    {
    int left = 0;
    int right = 0;
    if (index != 0)
    {
        for (int i = 0; i < index; i++)
        {
            left += arr[i];
        }
    }
    
    if (index != arr.Length-1)
    {
        for (int i = index+1; i < arr.Length; i++) {
            right += arr[i];
        }
    }
    
    
    if (left == right) { return index; }
    }
    
    return -1;
  }
}


/*----------------------------------------REFACTOR 1----------------------------------------*/

public class Refactor1
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
        int left = arr.Take(index).Sum();
        int right = arr.Skip(index+1).Sum();

        if(left == right) { return index; }
        }
        return -1;
    }
}


/*----------------------------------------REFACTOR 2----------------------------------------*/

public class Refactor2
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            if(arr.Take(index).Sum() == arr.Skip(index+1).Sum()) { return index; }
        }
        return -1;
    }
}
