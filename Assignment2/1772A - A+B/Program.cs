

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var res = Console.ReadLine().Split('+').Select(x => int.Parse(x)).ToList().Sum();
    Console.WriteLine(res);
}