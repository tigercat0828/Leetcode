

using System.Net.Mail;
using System.Security.AccessControl;

namespace Leetcode.CSharp.Solutions;

public class Leetcode2490
{
    public bool IsCircularSentence(string sentence)
    {

        if(sentence == null) return false;
        if(sentence.Length == 1) return true;

        List<string> words = [.. sentence.Split(' ')];
        if (words.Count == 1)
        {
            string word = words[0];
            if (word[0] == word[^1]) return true;
        }
        else
        {
            for (int i = 0; i < words.Count-1; i++)
            {
                string first = words[i];
                string second = words[i+1];
                char a = first[^1];
                char b = second[0];
                if(a!=b) return false;
            }
            if (sentence[0] != sentence[^1]) return false;
            return true;
        }

        return false;
    }

}
