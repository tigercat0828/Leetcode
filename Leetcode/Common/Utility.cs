namespace Leetcode.Common {
    public static class Utility {
        public static string GenerateProblemString() {
            string problemString = Console.ReadLine();
            string[] tokens = problemString.Split(' ');
            tokens[0] = tokens[0].Remove(tokens[0].Length - 1);

            string className = "P" + string.Join('_', tokens);
            Console.WriteLine(className);
            return className;
        }

    }
}