

var n = int.Parse(Console.ReadLine());
var prices = Console.ReadLine().Split().Select(int.Parse).ToList();
var days = int.Parse(Console.ReadLine());
for (int i = 0; i < days; i++)
{
    var day1 = int.Parse(Console.ReadLine());
    var res = prices.Where(x => x <= day1).Count();
    Console.WriteLine(res);
}

