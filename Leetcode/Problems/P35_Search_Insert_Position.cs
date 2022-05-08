namespace Leetcode.Problems {
    public class P35_Search_Insert_Position {
        // O(logn)
        public int SearchInsert(int[] nums, int target) {
            return Search(nums, target, 0, nums.Length - 1);
        }
        private int Search(int[] nums, int target, int left, int right) {
            if (left < right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    return mid;
                }
                if (nums[mid] > target) {
                    return Search(nums, target, left, mid - 1);
                }
                else {
                    return Search(nums, target, mid + 1, right);
                }
            }
            else if (left == right) {
                if (target <= nums[left]) {
                    return left;
                }
                if (target > nums[left]) {
                    return left + 1;
                }

            }
            return left;
        }
    }
}
