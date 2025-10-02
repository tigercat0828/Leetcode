// time O(n)
// space O(n)
class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> map; // <target - nums[i] , i>

        for(int i=0;i<nums.size();i++){
            if(map.count(nums[i])){
                return vector<int>{ map[nums[i]] ,i };
            }
            else{
                map[target-nums[i]]= i;
            }
        }
        return vector<int>{};       // error
    }
};
/*
    [2,7,11,15] t=9
->  [7,2,-2,-6]
       ^ find 
*/