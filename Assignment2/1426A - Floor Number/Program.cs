

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var input = Console.ReadLine().Split();
    int n = int.Parse(input[0]);
    int x = int.Parse(input[1]);

    int sum = 0;
    int count = 0;

    sum += 2;
    count = 1;

    if (n <= 2)
    {
        Console.WriteLine(count);
        continue;
    }

    while (sum < n)
    {
        sum += x;
        count++;
    }

    Console.WriteLine(count);
}