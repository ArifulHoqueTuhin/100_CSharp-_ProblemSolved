

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());

    string row1 = Console.ReadLine();
    string row2 = Console.ReadLine();
    
    string newRow1 = row1.Replace('G', 'B');
    string newRow2 = row2.Replace('G', 'B');

    Console.WriteLine(newRow1 == newRow2 ? "YES" : "NO");
}
