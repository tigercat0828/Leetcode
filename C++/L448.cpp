// Time : O(n)
// Space : O(n)

class Solution1 {
public:
    vector<int> findDisappearedNumbers(vector<int>& nums) {
        int n = nums.size();
        unordered_set<int> set;
        for(int num : nums){
            set.insert(num);
        }
        vector<int> result;
        for(int i =1;i<=n;i++){
            if(set.count(i) == 0){
                result.push_back(i);
            }
        }
        return result;
    }
};


// Time : O(n)
// Space : O(1)

class Solution2 {
public:
    vector<int> findDisappearedNumbers(vector<int>& nums) {
        int n = nums.size();
        // use the input array as record
        for(int num : nums){
            int index = std::abs(num) -1;
            if(nums[index] > 0) nums[index] = -nums[index];
        }
        vector<int> result;
        for(int i = 0; i < n; i++){
            if(nums[i] > 0) result.push_back(i+1);
        }
        return result;
    }
};