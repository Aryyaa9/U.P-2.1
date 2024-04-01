using System;
class Program
{ static bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
                return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 2, 40, 8, 11 };
        
        Console.WriteLine(ContainsDuplicate(nums));
    }
}