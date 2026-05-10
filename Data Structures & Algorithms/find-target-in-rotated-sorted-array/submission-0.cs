public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
int r = nums.Length - 1;

while (l <= r)
{
    int m = (r + l) / 2;
   
    if (nums[m] >= nums[l])
    {
        if (nums[m] == target)
            return m;

        if (target >= nums[l] && target < nums[m])
            r = m - 1;
        else
            l = m + 1;



    }
    else
    {
        if (nums[m] == target)
            return m;
        if (target > nums[m] && target <= nums[r])
            l = m + 1;
        else
            r = m - 1;
    }
}
return -1;

    }
}
