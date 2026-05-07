public class Solution {
    public int CharacterReplacement(string s, int k) {
         Dictionary<char,int> map = new Dictionary<char,int>();

 int l = 0;
 int maxFreq = 0;

 int maxLen = 0;
 for (int r = 0; r < s.Length; r++)
 {
     char c = s[r];
     if (map.ContainsKey(c))
     {
         map[c]++;
     }
     else
     {
         map[c] = 1;
     }
     maxFreq = Math.Max(maxFreq, map[c]);
     if ((r - l + 1) - maxFreq>k)
     {
         map[s[l]]--;
         l++;
     }
     maxLen = Math.Max(maxLen, (r - l + 1));
 }
 return maxLen;
    }
}
