
var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
var n = input[0];
var k  = input[1];
int count = 0;
int time = 0;

for (int i = 1; i <= n; i++)
{
    time += 5 * i;
    if (time + k <= 240)
    {
        count++;
    }
}

Console.WriteLine(count);