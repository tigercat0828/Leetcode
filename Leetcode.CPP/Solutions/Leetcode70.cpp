class Solution {
public:
    int climbStairs(int n) {
		if (n < 3) return n;
		int A = 1;
		int B = 2;
		int C = 3;
		for (int i = 3; i <= n; i++) {
			C = A+ B;
			A = B;
			B = C;
		}
		return n;
    }
	// A B C
	//   A B C
	// 1 2 3 5 7
	// 1 2 3 4 5
};