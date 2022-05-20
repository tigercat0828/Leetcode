using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P1491_Average_Salary_Excluding_the_Minimum_and_Maximum_Salary {
        public double Average(int[] salary) {
            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            for (int i = 0; i < salary.Length; i++) {
                sum += salary[i];
                if (salary[i] > max) {
                    max = salary[i];
                }
                if (salary[i] < min) {
                    min = salary[i];
                }
            }
            sum -= (max + min);
            double average = sum / (salary.Length - 2);
            return average;
        }
    }
}
