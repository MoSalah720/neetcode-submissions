public class Solution {
    public int[] ReplaceElements(int[] arr) {
         int maxFar = -1;
 for (int i = arr.Length-1; i >= 0; i--)
 {
     int Current = arr[i];
     arr[i] = maxFar;
     maxFar = Math.Max(maxFar, Current);
 }
 return arr;
    }
}