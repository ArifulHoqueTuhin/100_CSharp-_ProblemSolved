



int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int taimur_distance = arr[0];
    int count = 0;
    for (int j = 1; j < arr.Length; j++)
    {
        if (arr[j] > taimur_distance)
            count++;
    }

    Console.WriteLine(count);
}