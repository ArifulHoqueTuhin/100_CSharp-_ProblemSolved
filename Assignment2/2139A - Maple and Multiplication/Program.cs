// See https://aka.ms/new-console-template for more information


int t = int.Parse(Console.ReadLine());

for (int j = 0; j < t; j++)
{
    int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int a = ab[0];
    int b = ab[1];

    if (a == b)
    {
        Console.WriteLine(0);
        continue;
    }

    if (a % b == 0 || b % a == 0)
    {
        Console.WriteLine(1);
        continue;
    }

    Console.WriteLine(2);
}
