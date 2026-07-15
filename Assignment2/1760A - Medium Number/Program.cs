
var t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderBy(x => x).ToList();
    var res = numbers[1];
    Console.WriteLine(res);
}
