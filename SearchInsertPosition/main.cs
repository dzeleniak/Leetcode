public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length-1;
        int val;
        while (l <= r) {
            int med = r+l/2;
            val = nums[med];
            if(val > target) {
                r = med-1;
            } else if(val < target) {
                l = med+1;
            } else {
                return med;
            }
        }
        
        return l;
        
    }
}