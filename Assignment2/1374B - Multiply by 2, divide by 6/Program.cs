

int t = int.Parse(Console.ReadLine()); 

for (int i = 0; i < t; i++)
{
    long n = long.Parse(Console.ReadLine());
    int moves = 0;
    bool possible = true;

    while (n != 1)
    {
        if (n % 6 == 0)
        {
            n /= 6;
            moves++;
        }
        else if (n % 3 == 0)
        {
            n *= 2;
            moves++;
        }
        else
        {
            possible = false;
            break;
        }
    }

    if (possible)
        Console.WriteLine(moves);
    else
        Console.WriteLine(-1);
}
