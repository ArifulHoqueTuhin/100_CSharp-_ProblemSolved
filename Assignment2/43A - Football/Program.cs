

int n = int.Parse(Console.ReadLine());
Dictionary<string, int> goals = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    string team = Console.ReadLine();

    if (!goals.ContainsKey(team))
        goals[team] = 0;

    goals[team]++;
}

string winner = goals.OrderByDescending(x => x.Value).First().Key;
Console.WriteLine(winner);
