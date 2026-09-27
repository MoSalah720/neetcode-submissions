public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
         int maxCon = 0 ;
 int currentCon = 0;
 for (int i = 0; i < nums.Length; i++)
 {
     if (nums[i] == 1)
     {
         currentCon++;
         maxCon = Math.Max(maxCon, currentCon);
     }
     else
     {
         currentCon = 0;
     }
 }
 return maxCon;
    }
}