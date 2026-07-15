

var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
var max = input.Max(x => x);
var min = input.Min(x => x);

var diff = min;
var same = (max - min) / 2;

Console.WriteLine($"{diff} {same}");

