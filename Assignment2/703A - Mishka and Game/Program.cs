
int n = int.Parse(Console.ReadLine());
int mishkaWins = 0;
int chrisWins = 0;

for (int i = 0; i < n; i++)
{
    string[] parts = Console.ReadLine().Split();
    int mi = int.Parse(parts[0]);
    int ci = int.Parse(parts[1]);

    if (mi > ci)
        mishkaWins++;
    else if (ci > mi)
        chrisWins++;
}

if (mishkaWins > chrisWins)
    Console.WriteLine("Mishka");
else if (chrisWins > mishkaWins)
    Console.WriteLine("Chris");
else
    Console.WriteLine("Friendship is magic!^^");
