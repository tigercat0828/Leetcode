// space: O(1)
// time : O(n)
class Solution {
public:
    int missingNumber(vector<int>& nums) {
        int n = nums.size();
        int sum = n*(n+1)/2;
        int result = sum;
        for(int num : nums){
            result -= num;            
        }
        return result;
    }
};