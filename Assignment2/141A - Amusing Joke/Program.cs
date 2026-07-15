

List<char> before = new List<char>();
List<char> after = new List<char>();
bool same = true;


for (int i = 0; i < 2; i++)
{
    var str = Console.ReadLine().ToCharArray();
    foreach (char c in str)
    {
        before.Add(c);
    }
}


var str2 = Console.ReadLine().ToCharArray();
foreach (char c in str2)
{
    after.Add(c);
}

before.Sort();
after.Sort();


if (before.Count != after.Count)
{
    Console.WriteLine("NO");
    return;
}

for (int i = 0; i < before.Count; i++)
{
    if (before[i] != after[i])
    {
        same = false;
        break;
    }
}

if (same)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");