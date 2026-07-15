

int n = int.Parse(Console.ReadLine());

int sum = 0;
int total = 0;
int i = 1;
int count = 0;
while (true)
{
    sum += i;
    if (total + sum > n)
        break;
    total += sum;
    count++;
    i++;
}

Console.WriteLine(count);