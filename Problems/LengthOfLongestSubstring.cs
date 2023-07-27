namespace LeetCode.Problems;

public static partial class Solution
{
    public static int LengthOfLongestSubstring(string s) {
        int longest = 0;
        int left = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int right = 0; right < s.Length; right++) {
            if (charIndexMap.ContainsKey(s[right]) && charIndexMap[s[right]] >= left) {
                left = charIndexMap[s[right]] + 1;
            }
            charIndexMap[s[right]] = right;
            longest = Math.Max(longest, right - left + 1);
        }

        return longest;
    }
}