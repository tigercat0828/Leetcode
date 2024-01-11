namespace Leetcode.CSharp.NotMine;
public class Leetcode1235 {
    struct Job(int startTime, int endTime, int profit) {
        public int startTime = startTime;
        public int endTime = endTime;
        public int profit = profit;
    }

    int[] memo = null!;
    List<Job> jobs = null!;
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit) {

        int length = startTime.Length;
        memo = new int[length];
        Array.Fill(memo, -1);
        jobs = new(length);

        for (int i = 0; i < length; i++) {
            Job job = new(startTime[i], endTime[i], profit[i]);
            jobs.Add(job);
        }

        jobs = [.. jobs.OrderBy(x => x.startTime)];

        return DFS(0);
    }
    private int DFS(int i) {
        if (i == memo.Length) {
            return 0;
        }
        if (memo[i] != -1) {
            return memo[i];
        }
        // not include, just pick the next job
        int result = DFS(i + 1);

        // include
        // check the closet non-overlay
        int j = FindNext(i);
        memo[i] = result = Math.Max(result, jobs[i].profit + DFS(j));
        return result;
    }
    private int FindNext(int index) {
        int lo = index + 1;
        int hi = jobs.Count - 1;
        int ans = jobs.Count;

        while (lo <= hi) {
            int mid = lo + (hi - lo) / 2;
            if (jobs[mid].startTime >= jobs[index].endTime) {
                ans = mid;
                hi = mid - 1;
            }
            else {
                lo = mid + 1;
            }
        }
        return ans;
    }
}
