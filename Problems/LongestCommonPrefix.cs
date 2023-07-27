namespace LeetCode.Problems;

public static partial class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        int minLength = strs.Min(s => s.Length);
        int commonPrefixLength = 0;

        for (int i = 0; i < minLength; i++)
        {
            char currentChar = strs[0][i];

            if (strs.All(s => s[i] == currentChar))
                commonPrefixLength++;
            else
                break;
        }

        return strs[0].Substring(0, commonPrefixLength);
    }
}