/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> cycle = new HashSet<ListNode>();
ListNode current = head;
while (current != null)
{
    if (cycle.Contains(current))
    {
        return true;
    }
    cycle.Add(current);
    current = current.next;
}
return false;
    }
}
