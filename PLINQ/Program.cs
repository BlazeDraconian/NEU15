//var list = Enumerable.Range(1, 20)
//    .AsParallel()
//    .Select(i => CostlyOperation(i))
//    .ToList();
//Console.WriteLine($"Processing complete. Here is the result:\n ");
//Console.WriteLine(string.Join(",", list));


//static int CostlyOperation(int n)
//{
//    Thread.Sleep(500);
//    Console.WriteLine($"Processing object {n}");
//    return n;
//}

long sum = Enumerable.Range(1, 1_000_000_000)
    .AsParallel()
    .Where(i => i % 3 == 0 || i % 5 == 0)
    .Select(i => (long)i)
    .Sum();
Console.WriteLine(sum);
Console.WriteLine();