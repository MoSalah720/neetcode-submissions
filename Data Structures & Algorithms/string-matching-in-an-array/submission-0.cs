public class Solution {
    public List<string> StringMatching(string[] words) {
         List<string> subStringWord = new List<string>();
 for (int i = 0; i < words.Length; i++)
 {
     for (int j = 0; j < words.Length; j++)
     {
         if (i != j)
         {
             if (words[j].Contains(words[i]))
             {
                 subStringWord.Add(words[i]);
                 break;
             }
         }
     }
 }
 return subStringWord;
    }
}