

var values = Console.ReadLine().Split().Select(int.Parse).ToList();


var max = values.Max();


List<int> all = new List<int> { 1, 2, 3, 4, 5, 6 };


int remain = all.Count(x => x >= max);
int denominator = 6;


int gcd = GCD(remain, denominator);
remain /= gcd;
denominator /= gcd;

Console.WriteLine($"{remain}/{denominator}");


static int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

