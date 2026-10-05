public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
     Dictionary<int,int> TopKFreq = new Dictionary<int,int>();
  foreach (var num in nums)
  {
      if (!TopKFreq.ContainsKey(num))
      {
          TopKFreq[num] = 1;
      }
      else
      {
          TopKFreq[num]++;
      }
  }
  var sorted = TopKFreq.ToList();
  sorted.Sort((x,y)=>y.Value.CompareTo(x.Value));
var result = sorted.Take(k).Select(x => x.Key).ToList();
  return result.ToArray();
}
    
}
