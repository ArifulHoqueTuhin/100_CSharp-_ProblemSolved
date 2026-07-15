
var fair = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderBy(x => x).ToList();
var x4 = fair.Max();

var a = x4 - fair[0];
var b = x4 - fair[1];
var c = x4 - fair[2];
Console.WriteLine($"{a} {b} {c}");
