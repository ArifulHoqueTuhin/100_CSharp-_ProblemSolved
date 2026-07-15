

var parts = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
string s = Console.ReadLine();
long total = 0;

foreach (char ch in s)
{
    int idx = ch - '1'; 
            if (idx >= 0 && idx < 4)
        total += parts[idx];
}

Console.WriteLine(total);

