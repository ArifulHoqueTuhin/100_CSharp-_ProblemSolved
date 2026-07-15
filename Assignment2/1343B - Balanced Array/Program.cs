

int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int half = n / 2;

    
    if (half % 2 != 0)
    {
        Console.WriteLine("NO");
        continue;
    }

    Console.WriteLine("YES");

    int[] arr = new int[n];
    int idx = 0;

   
    for (int i = 1; i <= half; i++)
        arr[idx++] = i * 2;

    
    for (int i = 1; i < half; i++)
        arr[idx++] = i * 2 - 1;

    
    arr[idx++] = 3 * half - 1;

    Console.WriteLine(string.Join(" ", arr));
}