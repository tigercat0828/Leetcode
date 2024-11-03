
namespace Leetcode.CSharp.Solutions;

public class Leetcode796
{
    public bool RotateString(string s, string goal)
    {
        if(s.Length > goal.Length) return false;
        string t = s+s;
        return t.Contains(goal);
    }
}
