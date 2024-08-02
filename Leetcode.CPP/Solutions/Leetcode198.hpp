#pragma once
#include <vector>
#include <algorithm>
using namespace std;
class Leetcode198 {
public:
    int* DP;
    int rob(vector<int>& nums) {
        if (nums.size() == 1) return nums[0];
        if (nums.size() == 2) return max(nums[0], nums[1]);

        int length = nums.size();
        DP = new int[length];
        DP[0] = nums[0];
        DP[1] = max(nums[0], nums[1]);
        for (int i = 2; i < length; i++) {
            DP[i] = max(DP[i - 1], DP[i - 2] + nums[i]);
        }
        return DP[length - 1];
    }
};