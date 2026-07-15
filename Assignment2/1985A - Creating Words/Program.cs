

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var parts = Console.ReadLine().Split();

    string a = parts[0];
    string b = parts[1];

  
    string newA = b[0] + a.Substring(1);
    string newB = a[0] + b.Substring(1);

    Console.WriteLine($"{newA} {newB}");
}