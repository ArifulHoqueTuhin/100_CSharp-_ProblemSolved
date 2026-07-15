

int[] num = { 4, 7, 4, 2, 9, 7, 3, 2, 8 };

(int number, List<int> indices)[] tuples = new (int, List<int>)[num.Length];

int k = 0;

for (int n = 0; n < num.Length; n++)
{
    bool find = false;
    for (int j = 0; j < num.Length; j++)
    {
        if (tuples[j].number == num[n])
        {
            find = true;
            tuples[j].indices.Add(n);
            break;

        }
    }
    if (!find)
    {
        tuples[k++] = (num[n], new List<int> {n});
    }
}

for (int i = 0; i < k; i++)
{
    Console.WriteLine($"{tuples[i].number} → {string.Join(",", tuples[i].indices)}");
}