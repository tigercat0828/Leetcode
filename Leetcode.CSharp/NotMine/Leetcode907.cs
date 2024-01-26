namespace Leetcode.CSharp.NotMine;
public class Leetcode907 { // (may be hard)
                           // monotonic stack 
    public int SumSubarrayMins(int[] arr) {
        long sum = 0;
        Stack<int> stack = [];
        for (int i = 0; i <= arr.Length; i++) {
            while (stack.Count > 0 && arr[stack.Peek()] > (i == arr.Length ? int.MinValue : arr[i])) {
                int mid = stack.Pop();
                int left = stack.Count == 0 ? -1 : stack.Peek();
                int right = i;
                sum += (long)arr[mid] * (mid - left) * (right - mid);
            }
            stack.Push(i);
        }
        return (int)(sum % 1000000007);
    }

    public int SumSubarrayMins_TLE(int[] arr) {

        // O(n^2)
        long result = 0;
        result += arr.Sum();
        List<int> subMin = [.. arr];
        List<int> temp = [];

        for (int i = 0; i < arr.Length - 1; i++) {

            int length = subMin.Count - 1;
            for (int t = 0; t < length; t++) {

                temp.Add(Math.Min(subMin[t], subMin[t + 1]));
            }
            // Console.WriteLine("> " + string.Join(',', temp));
            result += temp.Sum();
            subMin = [.. temp];
            temp.Clear();
        }
        return (int)(result % (1000000000 + 7));
    }
}