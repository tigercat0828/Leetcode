using Leetcode.CSharp.Problems;


Console.WriteLine(TimeProvider.System.GetUtcNow());
await Task.Delay(2000);
Console.WriteLine(TimeProvider.System.GetUtcNow());
