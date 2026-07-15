

var nm = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
var m = nm[1];
var prices = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderBy(x => x).ToList();
var res = 0;

for (int i = 0; i < m && prices[i] < 0; i++)
{
    res += Math.Abs(prices[i]);
}

Console.WriteLine(res);
