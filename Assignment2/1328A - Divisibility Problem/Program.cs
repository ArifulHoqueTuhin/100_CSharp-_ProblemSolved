
var test = int.Parse(Console.ReadLine());

for (int i = 0; i < test; i++)
{
    var ab = Console.ReadLine().Split().Select(long.Parse).ToArray();
    long a = ab[0];
    long b = ab[1];

    long moves = (b - (a % b)) % b;
    Console.WriteLine(moves);
}


