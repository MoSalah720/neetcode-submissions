public class Solution {
    public int MaxProfit(int[] prices) {
         int Maxpro = 0;
 int minBuy = prices[0];

 foreach (var sell in prices)
 {
     Maxpro = Math.Max(Maxpro, sell - minBuy);
     minBuy = Math.Min(minBuy, sell);
 }
 return Maxpro;
    }
}
