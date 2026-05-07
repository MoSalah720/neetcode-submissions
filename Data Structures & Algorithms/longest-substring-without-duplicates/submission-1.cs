public class Solution {
    public int LengthOfLongestSubstring(string s) {
              int l = 0;
 HashSet<char> set = new HashSet<char>();
 int MaxLenght = 0;
 for (int r = 0; r <s.Length; r++)
 {
     while (set.Contains(s[r]))
     {
         set.Remove(s[l]);
         l++;
     }
     set.Add(s[r]);
     MaxLenght =Math.Max(MaxLenght, r - l + 1);
 }

 return MaxLenght;
    }
}
