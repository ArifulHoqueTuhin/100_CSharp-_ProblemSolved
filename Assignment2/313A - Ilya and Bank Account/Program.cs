




int n = int.Parse(Console.ReadLine());

if (n >= 0)
{
    Console.WriteLine(n);
    return;
}

int removeLast = n / 10;
int lastDigit = n % 10;
int removeBeforeLast = (n / 100) * 10 + lastDigit;


Console.WriteLine(Math.Max(removeLast, removeBeforeLast));


