namespace Leetcode.Problems {
    public class P1091_Shortest_Path_in_Binary_Matrix {
        private bool[][] VisitedTable;
        private int row;
        private int col;
        // BFS O(mn)
        public int ShortestPathBinaryMatrix(int[][] grid) {

            row = grid.Length;
            col = grid[0].Length;
            // edge case
            if (grid[0][0] == 1) return -1;
            if (grid[row - 1][col - 1] == 1) return -1;

            BuildVisitedTable(grid);
            //PrintMatrix(grid);
            //PrintMatrix(VisitedTable);

            Queue<Node> queue = new Queue<Node>();

            Vector2 current = new Vector2(0, 0);
            Vector2 endPoint = new Vector2(row - 1, col - 1);

            SetVisited(current);
            queue.Enqueue(new Node(current, 1));

            while (queue.Count > 0) {
                Node pop = queue.Dequeue();
                if (pop.pos == endPoint) return pop.step;   // goal
                for (int i = 0; i < directions.Length; i++) {
                    Vector2 next = new Vector2(pop.pos + directions[i]);

                    if (!IsValidPos(next)) continue;

                    if (!IsVisited(next)) {
                        SetVisited(next);
                        queue.Enqueue(new Node(next, pop.step + 1));
                        // Console.WriteLine($"En {next}");
                    }
                }
            }
            return -1; // no path
        }
        private bool IsValidPos(Vector2 pos) {
            if (pos.x < 0 || pos.x >= row) {
                return false;
            }
            if (pos.y < 0 || pos.y >= col) {
                return false;
            }
            return true;
        }
        private bool IsVisited(Vector2 pos) => VisitedTable[pos.x][pos.y];
        private void SetVisited(Vector2 pos) => VisitedTable[pos.x][pos.y] = true;
        private void BuildVisitedTable(int[][] grid) {
            VisitedTable = new bool[row][];
            for (int i = 0; i < row; i++) {
                VisitedTable[i] = new bool[col];
                for (int j = 0; j < col; j++) {
                    VisitedTable[i][j] = (grid[i][j] == 1);
                }
            }
        }

        private void PrintMatrix<T>(T[][] grid) {
            int row = grid.Length;
            int col = grid[0].Length;
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    Console.Write(grid[i][j]);
                }
                Console.WriteLine();
            }
        }
        struct Vector2 {
            public int x;
            public int y;
            public Vector2(int x, int y) {
                this.x = x;
                this.y = y;
            }
            public Vector2(Vector2 v) {
                x = v.x;
                y = v.y;
            }
            public static bool operator !=(Vector2 left, Vector2 right) => left.x != right.x || left.y != right.y;
            public static bool operator ==(Vector2 left, Vector2 right) => left.x == right.x && left.y == right.y;
            public static Vector2 operator +(Vector2 left, Vector2 right) {
                return new Vector2(left.x + right.x, left.y + right.y);
            }
            public override string ToString() {
                return $"({x}, {y})";
            }
        }
        struct Node {
            public int step;
            public Vector2 pos;
            public Node(Vector2 pos, int step) {
                this.pos = pos;
                this.step = step;
            }
        }
        Vector2[] directions = new Vector2[8] {
        new Vector2(1,0),
        new Vector2(1,-1),
        new Vector2(0,-1),
        new Vector2(-1,-1),
        new Vector2(-1, 0),
        new Vector2(-1, 1),
        new Vector2(0, 1),
        new Vector2(1, 1),
    };
    }
}
