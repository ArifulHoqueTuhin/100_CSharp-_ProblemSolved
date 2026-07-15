
int t = int.Parse(Console.ReadLine());

for (int i = 0; i< t; i++)
{
    int n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    List<char> solved = new List<char>();
    int totalBalloons = 0;

    foreach (char ch in s)
    {
        if (solved.Contains(ch))
        {
            totalBalloons += 1;
        }
        else
        {
            totalBalloons += 2;
            solved.Add(ch);
        }
    }

    Console.WriteLine(totalBalloons);
}
