

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int a = values[0];
    int b = values[1];
    int c = values[2];

    if (a + b == c)
        Console.WriteLine("+");
    else
        Console.WriteLine("-");
}