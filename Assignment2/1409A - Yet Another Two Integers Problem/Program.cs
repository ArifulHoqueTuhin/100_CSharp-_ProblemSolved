


int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    var ab = Console.ReadLine().Split().Select(long.Parse).ToArray();
    long a = ab[0];
    long b = ab[1];

    long diff = Math.Abs(a - b);
    long moves = diff / 10;
    if (diff % 10 != 0) 
        moves++;

    Console.WriteLine(moves);

}

    