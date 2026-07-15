
var n = int.Parse(Console.ReadLine());
var lists = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
var max = lists.Max();
var sum = lists.Sum();
var res = (max * n) - sum;
Console.WriteLine(res);