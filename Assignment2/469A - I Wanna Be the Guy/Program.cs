

var n = int.Parse(Console.ReadLine());

HashSet<int> result = new HashSet<int>();

var xInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int p = xInput[0];
for (int i = 1; i <= p; i++)
{
    result.Add(xInput[i]);
}

var yInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int q = yInput[0]; 
for (int i = 1; i <= q; i++)
{
    result.Add(yInput[i]);
}

var complete = result.Count();
if (complete == n)
{
    Console.WriteLine("I become the guy.");
}

else
{
    Console.WriteLine("Oh, my keyboard!");
}