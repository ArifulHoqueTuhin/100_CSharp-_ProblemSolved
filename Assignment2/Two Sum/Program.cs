using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {  // avoid index out of range
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        // if no solution found
        return new int[] { };
    }
}

public class Program
{
    public static void Main()
    {
        Solution s1 = new Solution();
        int[] result = s1.TwoSum(new int[] { 3, 2, 4 }, 6);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}
