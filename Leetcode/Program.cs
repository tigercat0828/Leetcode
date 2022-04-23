using Leetcode;
using Leetcode.Common;
using Leetcode.Problems;
using System.Collections;
using static System.Console;



Random random = new Random();
for (int i = 0; i < 10; i++) {
    Console.WriteLine(30);
    Console.WriteLine(random.Next(1, (int)MathF.Pow(2, 29)));
}

P779_Kth_Symbol_in_Grammar P = new();
P.KthGrammar(30, 515676024);
