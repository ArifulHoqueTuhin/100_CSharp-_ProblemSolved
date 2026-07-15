

var t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var str = Console.ReadLine();
    if (str.Length % 2 != 0)
    {
        Console.WriteLine("NO");
        continue;
    }

    var half = str.Length / 2;
    string first = str.Substring(0, half);
    string second = str.Substring(half);

    Console.WriteLine(first == second ? "YES" : "NO");


}
