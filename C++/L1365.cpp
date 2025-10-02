// Time O(n)
// Space O(n)
class Solution {
public:
    vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
        vector<int> count(101,0);   // input range is [0,100] it's reasonable open a array
        for(int num : nums) count[num]++;    // O(n)
        
        // build the prefix sum
        for(int i=1;i<count.size();i++){
            count[i] += count[i-1];
        }

        vector<int> result;
        for(int num : nums){
            if(num ==0) 
                result.push_back(0);
            else
                result.push_back(count[num-1]);
        }

        return result;
    }
};


/*
input   [8,1,2,2,3]
count
index   [0,1,2,3,4,5,6,7,8,9]
value   [0,1,2,1,0,0,0,0,1,0]
presum  [0,1,3,4,4,4,4,4,5,0]
count 
*/



// Time O(nlogn)
// Space O(n)
class Solution {
public:
    vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
        // O(n) copy
        vector<int> sorted = nums;
        std::sort(sorted.begin(), sorted.end());
        // O (nlogn)
        unordered_map<int, int> count; // <nums[i], i> 記index（贏過地幾個）
        // O(n) record the rank
        for(int i =0;i<sorted.size();i++){
            if(count.find(sorted[i]) == count.end()){
                count[sorted[i]] = i;
            }
        }
        // O(n) retreive the answer
        vector<int> result;
        for(int num : nums){
            result.push_back(count[num]);
        }
        return result;
    }
};

/*
        [8,1,2,2,3]
>sort   [1,2,2,3,8]
>map    [0,1,1,3,4]
>use key retreive answer
*/



// Time O(n^2)
// Space O(n) (result)
class Solution3 {
public:
    vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
        vector<int> result;
        for(int i =0; i<nums.size(); i++){
            int count = 0;
            for(int j=0; j<nums.size(); j++){
                if(i==j) continue;
                if(nums[i] > nums[j]) count++;
            }
            result.push_back(count);
        }
        return result;
    }
};



