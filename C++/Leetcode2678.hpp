#pragma once
#include <string>
#include <vector>
#include <cstdlib>
using namespace std;
class Leetcode2678 {
public:
    int countSeniors(vector<string>& details) {
        int validNum = 0;
        for (auto detail : details) {
            int length = detail.length();
            if (length < 0 || length >15) continue;
            int age = atoi(detail.substr(11, 2).c_str());
            if (age > 60) validNum++;
        }
        return validNum;
    }
};