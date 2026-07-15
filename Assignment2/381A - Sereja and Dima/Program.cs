

int n = int.Parse(Console.ReadLine());
var values = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int left = 0;
int right = n - 1;

int sereja = 0;
int dima = 0;

for (int i = 0; i < n; i++)
{
    int chosen;
    if (values[left] > values[right])
    {
        chosen = values[left];
        left++;
    }
    else
    {
        chosen = values[right];
        right--;
    }

    if (i % 2 == 0)
        sereja += chosen;
    else
        dima += chosen;
}

Console.WriteLine($"{sereja} {dima}");
    