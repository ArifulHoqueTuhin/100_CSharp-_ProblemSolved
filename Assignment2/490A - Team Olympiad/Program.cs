


int n = int.Parse(Console.ReadLine());
var skills = Console.ReadLine().Split().Select(int.Parse).ToList();

var programmers = new List<int>();
var mathematicians = new List<int>();
var athletes = new List<int>();

for (int i = 0; i < n; i++)
{
    if (skills[i] == 1) programmers.Add(i + 1);
    else if (skills[i] == 2) mathematicians.Add(i + 1);
    else athletes.Add(i + 1);
}

int teamCount = Math.Min(programmers.Count, Math.Min(mathematicians.Count, athletes.Count));

Console.WriteLine(teamCount);
for (int i = 0; i < teamCount; i++)
{
    Console.WriteLine($"{programmers[i]} {mathematicians[i]} {athletes[i]}");
}
