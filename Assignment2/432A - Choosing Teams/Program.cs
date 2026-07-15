

var nk = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
var n = nk[0];
var k = nk[1];
var values = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).OrderByDescending(x => x).ToArray();
var eligible = values.Count(x => x + k <= 5);
var teams = eligible / 3;
Console.WriteLine(teams);