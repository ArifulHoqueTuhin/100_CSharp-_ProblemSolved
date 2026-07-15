

int t = int.Parse(Console.ReadLine()); 

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    int left = 0;
    int right = n - 1;

    while (left < right && s[left] != s[right])
    {
        left++;
        right--;
    }

 
    Console.WriteLine(right - left + 1);
}