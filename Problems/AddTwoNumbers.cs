namespace LeetCode.Problems;

public static partial class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, out int carry) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        carry = 0;

        while (l1 != null || l2 != null || carry != 0) {
            int sum = carry;

            if (l1 != null) {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null) {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            sum %= 10;

            current.next = new ListNode(sum);
            current = current.next;
        }

        return dummy.next;
    }
}