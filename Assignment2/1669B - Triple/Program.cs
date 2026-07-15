

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
  
    Dictionary<int, int> freq = new Dictionary<int, int>();
    int result = -1;

    foreach (int num in input)
    {
        if (!freq.ContainsKey(num))
            freq[num] = 1;
        else
            freq[num]++;
 
        if (freq[num] >= 3)
        {
            result = num;
            break; 
        }
    }

    Console.WriteLine(result);
}