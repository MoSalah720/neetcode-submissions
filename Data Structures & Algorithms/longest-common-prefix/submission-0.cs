public class Solution {
    public string LongestCommonPrefix(string[] strs) {
      string prefix = strs[0];
string currentWord;
for (int i = 1; i < strs.Length; i++)
{
    currentWord = strs[i] ;
    int current = 0;
    while (current < prefix.Length && current < currentWord.Length && prefix[current] == currentWord[current])
    {
        current++;
    }
    prefix = prefix.Substring(0, current);
}
return prefix;  
    }
}