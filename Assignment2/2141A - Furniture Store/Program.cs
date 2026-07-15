// See https://aka.ms/new-console-template for more information


int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int[] a2 = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();

    List<int> Ordered = new List<int>();
    int minPrice = a2[0];

    for (int j = 1; j < n; j++)
    {
        if (a2[j] > minPrice)
        {
            Ordered.Add(j + 1); 
        }
        else
        {
            minPrice = a2[j];
        }
    }

    Console.WriteLine(Ordered.Count);
    if (Ordered.Count > 0)
    {
        Console.WriteLine(string.Join(" ", Ordered));
    }
    else
    {
        Console.WriteLine();
    }

}