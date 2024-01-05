namespace Leetcode.CSharp.Solutions {
    public class P1281_Subtract_the_Product_and_Sum_of_Digits_of_an_Integer {
        public int SubtractProductAndSum(int n) {
            int product = 1;
            int sum = 0;
            List<int> digits = ToDigits(n);
            foreach (var d in digits) {
                product *= d;
                sum += d;
            }
            return product - sum;


        }
        List<int> ToDigits(int n) {
            List<int> digits = new List<int>();
            while (n > 0) {
                digits.Add(n % 10);
                n /= 10;
            }
            return digits;
        }
    }
}
