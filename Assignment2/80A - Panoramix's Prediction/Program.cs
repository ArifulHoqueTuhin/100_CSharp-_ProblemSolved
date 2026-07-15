

var input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

int next = NextPrime(n);

if (m == next)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");

int NextPrime(int n)
{
    int next_value = n + 1;
    while (true)
    {
        if (IsPrime(next_value)) return next_value;
        next_value++;
    }
}

bool IsPrime(int x)
{
    if (x < 2) return false;
    for (int i = 2; i < x; i++)
    {
        if (x % i == 0) return false;
    }
    return true;
}


