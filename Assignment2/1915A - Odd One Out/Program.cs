

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int a = nums[0], b = nums[1], c = nums[2];

    int result;

    if (a == b)
        result = c;
    else if (a == c)
        result = b;
    else
        result = a;

    Console.WriteLine(result);
}
