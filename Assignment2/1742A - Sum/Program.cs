

int test = int.Parse(Console.ReadLine());

for (int i = 0; i < test; i++)
{
    var nums = Console.ReadLine().Split(' ');
    int a = int.Parse(nums[0]);
    int b = int.Parse(nums[1]);
    int c = int.Parse(nums[2]);

    if (a == b + c || b == a + c || c == a + b)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}
