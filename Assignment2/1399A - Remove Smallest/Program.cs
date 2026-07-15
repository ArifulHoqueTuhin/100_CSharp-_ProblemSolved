


var t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var n = int.Parse(Console.ReadLine());
    var arr = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();

    bool possible = true;

    for (int j = 0; j < arr.Length - 1; j++)
    {
        if (arr[j + 1] - arr[j] > 1)
        {
            possible = false;
            break;
        }
    }

    Console.WriteLine(possible ? "YES" : "NO");
}

 