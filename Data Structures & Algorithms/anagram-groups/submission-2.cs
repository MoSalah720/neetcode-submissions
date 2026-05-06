public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
            Dictionary<string, List<string>> GA = new Dictionary<string, List<string>>();
 foreach (var s in strs)
 {
     int[] count = new int[26];

     foreach (char c in s)
     {
         count[c - 'a']++;
     }
     string key = string.Join(",", count);
     if (!GA.ContainsKey(key))
     {
         GA[key] = new List<string>();
     }
     GA[key].Add(s);
 }
 return GA.Values.ToList<List<string>>();
    }
}
