

var test = int.Parse(Console.ReadLine());
for (int i = 0; i < test; i++)
{
    var tickts = Console.ReadLine();
    var first = tickts.Substring(0, 3).Select(x => x - '0').Sum();  
    var last = tickts.Substring(3, 3).Select(x => x - '0').Sum();

    if (first == last)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");


}
