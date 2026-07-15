


var t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int a = ab[0];
    int b = ab[1];
    int c = a;

    var res = (c - a) + (b - c);
    Console.WriteLine(res);
    res = 0;
}
