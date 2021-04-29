using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MerginList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> nums2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> resultNums = new List<int>();
            for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
            {
                resultNums.Add(nums1[i]);
                resultNums.Add(nums2[i]);
            }
            for (int i = Math.Min(nums1.Count, nums2.Count); i < Math.Max(nums1.Count, nums2.Count); i++)
            {

            if (nums1.Count > nums2.Count)
            {
                resultNums.AddRange(GetRemainingElements(nums1, nums2));
            }
            else
            {
                resultNums.AddRange(GetRemainingElements(nums1, nums2));
            }
        }
        Console.WriteLine(string.Join(" ", resultNums));
        }

    static List<int> GetRemainingElements(List<int> longerList, List<int> shortList)
    {
        List<int> nums = new List<int>();
        for (int i = shortList.Count; i < longerList.Count; i++)
        {
            nums.Add(longerList[i]);
        }
        return nums;
    }
}
}
