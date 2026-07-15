

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var parts = Console.ReadLine().Split();
    long x = long.Parse(parts[0]);
    long y = long.Parse(parts[1]);
    long n = long.Parse(parts[2]);

    long k = n - ((n - y) % x);
    Console.WriteLine(k);
}
