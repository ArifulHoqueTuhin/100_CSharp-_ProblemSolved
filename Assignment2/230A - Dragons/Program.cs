

var sn = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
var s = sn[0];
var n  = sn[1];
bool defeat = true;

List<(int strength, int bonus)> dragons = new List<(int, int)>();
for (int i = 0; i < n; i++)
{
    var sb = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    dragons.Add((sb[0],sb[1]));
}

dragons = dragons.OrderBy(x => x.strength).ToList();

foreach (var dragon in dragons)
{
    if (s > dragon.strength)
    {
        s += dragon.bonus;
    }
    else
    {
        defeat = false;
        break;
    }

}

Console.WriteLine(defeat ? "YES" : "NO");