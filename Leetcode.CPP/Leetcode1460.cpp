#include <vector>
using std::vector;
class Leetcode1460 {
public:
    bool canBeEqual(vector<int>& target, vector<int>& arr) {
        if (target.size() != arr.size()) return false;

        vector<int> dictT(1001, 0);
        vector<int> dictA(1001, 0);

        for (int i = 0; i < arr.size(); i++) {
            dictT[target[i]]++;
            dictA[arr[i]]++;
        }
        for (int i = 0; i < 1001; i++) {
            if (dictT[i] != dictA[i]) return false;
        }

        return true;
    }
};