

var test = int.Parse(Console.ReadLine());

for (int i = 0; i < test; i++)
{
    List<int> list = new List<int>();
    int n = int.Parse(Console.ReadLine());
    int place = 1; 

    while (n > 0)
    {
        int digit = n % 10; 
        if (digit != 0)
        {
            list.Add(digit * place);
        }
        n /= 10;
        place *= 10;
    }

    Console.WriteLine(list.Count); 
    Console.WriteLine(string.Join(" ", list)); 
}