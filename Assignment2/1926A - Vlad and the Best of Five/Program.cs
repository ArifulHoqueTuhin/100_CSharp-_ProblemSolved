

int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string s = Console.ReadLine().Trim();

    int countA = 0, countB = 0;

    foreach (char c in s)
    {
        if (c == 'A') countA++;
        else if (c == 'B') countB++;
    }

    if (countA > countB)
        Console.WriteLine("A");
    else
        Console.WriteLine("B");
}