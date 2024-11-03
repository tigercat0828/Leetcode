// Leetcode.CPP.cpp : 此檔案包含 'main' 函式。程式會於該處開始執行及結束執行。
//

#include <iostream>
#include <string>
using namespace std;
int main()
{
    string s = "abcde";
    string goal = "abced";
    string t = s + s;
    cout << t << endl;
    cout << t.find(goal) << endl;
    if (t.find(goal) < 0) {
        cout << "not" << endl;
    }
    
    return 0;
}

