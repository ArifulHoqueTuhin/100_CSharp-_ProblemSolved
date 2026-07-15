// See https://aka.ms/new-console-template for more information


var stop = int.Parse(Console.ReadLine());
int[] exit = new int[stop];
int [] entry = new int[stop];
int current = 0;
int res = 0;
int[] inside = new int[stop];

for (int i = 0; i < stop; i++)
{
    string a = (Console.ReadLine());
    string[] a1 = a.Split(" ");
    exit[i] = int.Parse(a1[0]);
    entry[i] = int.Parse(a1[1]);
}

for (int i = 0; i < stop ; i++)
{
   res = entry[i] - exit[i];
    current += res;
    inside[i] = current;
}

var min_capacity = inside.Max();

Console.WriteLine(min_capacity);