
var test = int.Parse(Console.ReadLine());

for (int i = 0; i < test; i++)
{
    var s = Console.ReadLine().ToUpper();

    if ( s == "YES")
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}