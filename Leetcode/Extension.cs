using System.Text;

namespace Leetcode {
    public static class Extension {
        public static string Print(this char[] arr) {
            StringBuilder sb = new StringBuilder();
            foreach (char c in arr) sb.Append(c);
            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}
