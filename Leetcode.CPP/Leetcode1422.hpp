#pragma once
#include <string>
#include <iostream>
#include <cmath>
#include <vector>
using namespace std;
class Leetcode1422 {
public:
    int maxScore(std::string s) {
        int length = s.length();
        vector<int> preZero(length, 0);         // from head to tail
        vector<int> postOne(length, 0);          // from tail to head
        // for debug
        // ==========================================
        preZero[0] = s[0] == '0';
        postOne[length - 1] = s[length-1] == '1';
         
        for (int i = 1; i < length; i++) {
            preZero[i] = preZero[i - 1] + (s[i] == '0');
        }
        for (int i = length - 2; i >= 0; i--) {
            postOne[i] = postOne[i + 1] + (s[i] == '1');
        }
       
        int answer = -1;
        for (int i = 1; i < length; i++) {
            answer = std::max(answer, preZero[i - 1] + postOne[i]);
        }
        return answer;
    }
};