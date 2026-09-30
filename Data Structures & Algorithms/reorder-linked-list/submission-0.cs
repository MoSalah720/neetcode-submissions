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
    public void ReorderList(ListNode head) {
         ListNode slow = head;
 ListNode fast = head;
 ListNode middle;
 while (fast !=null && fast.next != null)
 {
     fast = fast.next.next;
     slow = slow.next;
 }
 
 ListNode list1 = head;
 ListNode list2 = slow.next;
 middle = slow;
 middle.next = null;
 ListNode prev = null;
 while (list2 != null)
 {
     ListNode next = list2.next;
     list2.next = prev;
     prev = list2;
     list2 = next;
 }
 while (list1 != null && prev != null)
 {
     ListNode next1 = list1.next;
     ListNode next2 = prev.next;
     list1.next = prev;
     prev.next = next1;
     list1 = next1;
     prev = next2;
 }
       
    }
}
