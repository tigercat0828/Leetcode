namespace Leetcode.Problems; 
public class Leetcode1146 {
    public class SnapshotArray {
        int[] array;
        int snapTime = 0;
        Dictionary<int, (int, int)> history = new Dictionary<int, (int, int)>();
        public SnapshotArray(int length) {
            array = new int[length];
        }

        public void Set(int index, int val) {
            array[index] = val;
        }

        public int Snap() {
            snapTime++;
            return snapTime-1;
        }

        public int Get(int index, int snap_id) {

        }
    }
}
