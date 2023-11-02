namespace Leetcode.CSharp.Problems {
    public class P1299_Replace_Elements_with_Greatest_Element_on_Right_Side {

        public int[] ReplaceElements(int[] arr) {
            int max = -1;
            for (int i = arr.Length - 1; i >= 0; i--) {
                int tmp = arr[i];
                arr[i] = max;
                max = Math.Max(tmp, arr[i]);
            }
            return arr;
        }


        public int[] ReplaceElements2(int[] arr) {
            for (int i = 0; i < arr.Length - 1; i++) {
                arr[i] = FindMax(arr, i + 1);
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
        private int FindMax(int[] arr, int index) {
            int max = arr[index];
            for (int i = index + 1; i < arr.Length; i++) {
                if (arr[i] > max) {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
