#include <vector>
using namespace std;

class Leetcode2134 {
public:
    int minSwaps(vector<int>& nums) {
        // find '1' in nums
        int totalOnes = count(nums.begin(), nums.end(), 1);
       
        // boundary case all are '1' or '0'
        if (totalOnes == 0 || totalOnes == nums.size()) return 0;

        // build the circular array
        nums.insert(nums.end(), nums.begin(), nums.end());

        int size = totalOnes;
        int i = 0;
        int j = size - 1;
        int ones = count(nums.begin(), nums.end(), 1);

        int minSwap = size - ones;
        while (j < nums.size() - 1) {
            if (nums[i] == 1) ones--;
            i++;
            j++;
            if (nums[j] == 1) ones++;
            minSwap = min(minSwap, size - ones);
        }
        return minSwap;
    }
};