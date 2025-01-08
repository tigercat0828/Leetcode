namespace Leetcode.CSharp.Solutions;

public class Leetcode1408 {
    public IList<string> StringMatching(string[] words) {
        HashSet<string> answers = [];
        foreach(var a in words){
            foreach(var b in words){
                if(a!=b && a.Contains(b)){
                    answers.Add(b);     
                }
            }
        }
        return [.. answers];
    }
}