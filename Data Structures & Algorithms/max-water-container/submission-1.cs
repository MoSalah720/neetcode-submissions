public class Solution {
    public int MaxArea(int[] heights) {
         int left = 0;
 int right = heights.Length - 1;
 int Max = 0;

 while (left < right)
 {
     int weight = right - left;
     int height = Math.Min(heights[left], heights[right]);
     int area = weight * height;

     Max = Math.Max(Max, area);
     if (heights[left] <= heights[right])
     {
         left++;
     }
     else 
         right--;
 }
 return Max;
    }
}
