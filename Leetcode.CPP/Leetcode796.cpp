#include <string>
using std::string;
class Leetcode796
{
public:
    bool rotateString(string s, string goal) {
        if (s.length() > goal.length()) return false;
        string t = s + s;
        return t.find(goal) != std::string::npos;
    }
};

