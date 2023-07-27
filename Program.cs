using LeetCode.Problems;

ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));


Console.WriteLine($"{Solution.AddTwoNumbers(l1, l2, out var carry).val} - Carry: {carry}");

Console.WriteLine($"Longest substring: {Solution.LengthOfLongestSubstring("aoodufhgndisdhfklsd")}");


int[] nums1 = {1, 3, 4, 5};
int[] nums2 = {8, 9, 10};


Console.WriteLine($"Median: {Solution.FindMedianSortedArrays(nums1, nums2)}");


string[] strs = {"flower","flow","flight"};

Console.WriteLine($"Longest prefix: {Solution.LongestCommonPrefix(strs)}");