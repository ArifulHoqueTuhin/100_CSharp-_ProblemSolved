

var t = int.Parse(Console.ReadLine());
var str = "codeforces";

for (int i = 0; i < t; i++)
{
    var ch = Console.ReadLine();

    if (str.Contains(ch))
        Console.WriteLine("YES");
      else
        Console.WriteLine("NO");
}