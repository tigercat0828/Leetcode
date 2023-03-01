namespace Leetcode.Common {
    public static class Utility {
        public static int[] RandomIntegerArray(int count, int min, int max) {
            int[] array = new int[count];
            Random random = new Random();
            for (int i = 0; i < count; i++) {
                array[i] = random.Next(min, max+1);
            }
            return array;
        }
    }
}