using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Problems; 
public class Leetcode1845 {
    public class SeatManager {
        int customerNum;
        public SeatManager(int n) {
            customerNum = 0;
        }

        public int Reserve() {
            customerNum++;
            return customerNum;
        }

        public void Unreserve(int seatNumber) {
            customerNum--;
        }
    }

}
