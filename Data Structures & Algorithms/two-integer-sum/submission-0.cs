public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> x= new Dictionary<int,int>();
 for (int i = 0; i < nums.Length; i++)
 {
     int needed;
     needed = target - nums[i];
     if (x.ContainsKey(needed))
     {
         return new int[] { x[needed], i };
     }
     x[nums[i]] = i;
 }
 return new int[0];
    }
}
