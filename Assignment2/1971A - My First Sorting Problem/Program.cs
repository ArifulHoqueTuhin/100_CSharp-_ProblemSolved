

var t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    var list = Console.ReadLine().Split().Select(x =>int.Parse(x)).OrderBy(x => x).ToList();
    for (int j = 0; j < list.Count -1; j++)
    {
        Console.WriteLine($"{list[j]} {list[j+1]}");
    }
}
