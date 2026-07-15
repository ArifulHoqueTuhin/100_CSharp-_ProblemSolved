

int t = int.Parse(Console.ReadLine()); 

for (int i = 0; i < t; i++)
{
    string[] parts = Console.ReadLine().Split(' ');
    int a = int.Parse(parts[0]);
    int b = int.Parse(parts[1]);
    int c = int.Parse(parts[2]);

    if (a < b && b < c)
        Console.WriteLine("STAIR");
    else if (a < b && b > c)
        Console.WriteLine("PEAK");
    else
        Console.WriteLine("NONE");
}


