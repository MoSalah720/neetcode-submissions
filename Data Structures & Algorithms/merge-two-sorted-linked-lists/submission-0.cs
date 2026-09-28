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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
         ListNode current1 = list1;
 ListNode current2 = list2;

 ListNode mergedList = new ListNode();
 ListNode currentMerged = mergedList;
 while(current1 != null && current2 != null)
 {
     if (current1.val <= current2.val)
     {
         currentMerged.next = new ListNode(current1.val);
         currentMerged = currentMerged.next;
         current1 = current1.next;
     }
     else
     {
         currentMerged.next = new ListNode(current2.val);
         currentMerged = currentMerged.next;
         current2 = current2.next;

     }
 }
 while (current1!=null)
 {
     currentMerged.next = new ListNode(current1.val);
     currentMerged = currentMerged.next;
     current1 = current1.next;
 }
 while (current2 != null)
 {
     currentMerged.next = new ListNode(current2.val);
     currentMerged = currentMerged.next;
     current2 = current2.next;
 }
 return mergedList.next;
    }
}