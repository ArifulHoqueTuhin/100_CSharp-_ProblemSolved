

var test = int.Parse(Console.ReadLine());

for (int i = 0; i < test; i++)
{
    var res = Console.ReadLine().ToArray().Select(x => x - '0').Sum();
    Console.WriteLine(res);
}
