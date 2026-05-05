public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
            Dictionary<string,List<string>> GA=new Dictionary<string,List<string>>();
for (int i = 0; i < strs.Length; i++)
{
    string word = strs[i];
    char [] arr = word.ToCharArray();
    Array.Sort(arr);
    string key = new string(arr);
    if (!GA.ContainsKey(key))
    {
        GA[key] = new List<string>();
    }
    GA[key].Add(word);

}
return new List<List<string>>(GA.Values);
    }
}
