

var t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var abc = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderByDescending(x => x).ToArray();
    var a = abc[0];
    var b = abc[1];
    var res = a + b;

    Console.WriteLine(res >= 10 ? "YES" : "NO");    

}
