namespace Leetcode.CSharp.Solutions;
public class Leetcode2559 {
    public int[] VowelStrings(string[] words, int[][] queries) {

        int[] answers = new int[queries.Length];
        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u'];
        bool[] accepted = new bool[words.Length];
        int[] prefixSum = new int[words.Length];

        for (int i = 0; i<words.Length; i++) {
            var first = words[i].First();   // start
            var last = words[i].Last();    // end
            if (vowels.Contains(first) && vowels.Contains(last)) accepted[i] = true;
        }
        //Console.WriteLine(string.Join(',', accepted));

        // prefix sum
        prefixSum[0] =  Convert.ToInt32(accepted[0]);

        for (int i = 1; i < prefixSum.Length; i++) {
            prefixSum[i] += prefixSum[i-1] + Convert.ToInt32(accepted[i]);
        }
        //Console.WriteLine(string.Join(',', prefixSum));
        for (int i = 0; i < answers.Length; i++) {
            int from = queries[i][0];
            int to = queries[i][1];
            Console.WriteLine($"q : {from}, {to}");
            int s = Convert.ToInt32(accepted[from]);
            answers[i] = prefixSum[to] - prefixSum[from] +s;
        }


        return answers;
    }
}
