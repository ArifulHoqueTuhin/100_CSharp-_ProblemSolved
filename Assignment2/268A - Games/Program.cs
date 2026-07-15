
var n = int.Parse(Console.ReadLine());
int j = 0;
int count = 0;

(int team, int[] color)[] team_color = new (int team, int[] color)[n];

for (int i = 0; i < n; i++)
{
    var colors = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    team_color[i] = (i,colors);
}

   while(j < n)
{
    if (j == team_color[j].team)
    {
        for (int i = 0; i < n; i++)
        {
            if (i == j)
            {
                continue;
            }
            else
            {
                if(team_color[j].color[0] == team_color[i].color[1])
                {
                    count++;
                    
                }

            }
        }
        j++;
    }
}
Console.WriteLine(count);

