

int n = int.Parse(Console.ReadLine());
int remain = 0;
int count = 0;

while (n != 0)
{
    if (n >= 100)
    {
        remain = n - 100;
        n = remain;
        count++;
        continue;
    }

    if (n >= 20)
    {
        remain = n - 20;
        n = remain;
        count++;
        continue;
    }

    if (n >= 10)
    {
        remain = n - 10;
        n = remain;
        count++;
        continue;
    }

    if (n >= 5)
    {
        remain = n - 5;
        n = remain;
        count++;
        continue;
    }

    if (n >= 1)
    {
        remain = n - 1;
        n = remain;
        count++;
        continue;
    }
}

Console.WriteLine(count);