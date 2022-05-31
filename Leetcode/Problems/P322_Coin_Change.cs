namespace Leetcode.Problems {

    public class P322_Coin_Change {
        public int CoinChange(int[] coins, int amount) {
            Queue<Node> queue = new Queue<Node>();
            bool[] dict = new bool[10001];
            queue.Enqueue(new Node(amount, 0));
            dict[amount] = true;
            while (queue.Count > 0) {
                Node pop = queue.Dequeue();
                if (pop.remain == 0) return pop.level;
                foreach (var coin in coins.Reverse()) {
                    int possible = pop.remain - coin;
                    if (possible >= 0 && !dict[possible]) {
                        queue.Enqueue(new Node(possible, pop.level + 1));
                        dict[possible] = true;
                    }
                }
            }
            return -1;
        }
        class Node {
            public int remain;
            public int level;
            public Node(int remain, int level) {
                this.remain = remain;
                this.level = level;
            }
        }
    }
}
