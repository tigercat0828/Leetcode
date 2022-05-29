namespace Leetcode.Problems {
    public class P1232_Check_If_It_Is_a_Straight_Line {
        public bool CheckStraightLine(int[][] coordinates) {
            if (coordinates.Length == 2) return true;

            double dx = coordinates[0][0] - coordinates[coordinates.Length - 1][0];
            double dy = coordinates[0][1] - coordinates[coordinates.Length - 1][1];
            if (dx == 0) {   // vertical line 
                int x = coordinates[0][0];
                for (int i = 1; i < coordinates.Length; i++) {
                    if (coordinates[i][0] != x) return false;
                }
                return true;
            }
            // Point oblique type
            Func<double, double> func = (x) => (dy / dx) * (x - coordinates[0][0]) + coordinates[0][1];
            for (int i = 1; i < coordinates.Length - 1; i++) {
                double tx = coordinates[i][0];
                double ty = coordinates[i][1];

                if (ty != func(tx)) return false;

            }
            return true;

        }

    }

}
