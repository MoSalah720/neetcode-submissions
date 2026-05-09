public class Solution {
    public string MinWindow(string s, string t) {
            Dictionary<char, int> map = new Dictionary<char, int>();
    int l = 0;
    int have = 0;
    int minLenght = int.MaxValue;
    int minLeft = 0;
    foreach (char c in t)
    {
        if (!map.ContainsKey(c))
        {
            map[c] = 1;
        }
        else
            map[c]++;
        
    }
    int need = map.Count;

    for (int r = 0; r < s.Length; r++)
    {

        if (map.ContainsKey(s[r]))
        {
            map[s[r]]--;
            if (map[s[r]] == 0)
            {
                have++;
            }

        }

        while (have == need)
        {
            if (r-l+1 <minLenght)
            {
                minLenght = r - l + 1;
                minLeft = l;
            }

            if (map.ContainsKey(s[l])&&map[s[l]] == 0)
            {
                have--;
            }
            if (map.ContainsKey(s[l]))
            {
                map[s[l]]++;

            }
            l++;
        }
    }
    return minLenght == int.MaxValue ? "" : s.Substring(minLeft, minLenght);
}
    }

