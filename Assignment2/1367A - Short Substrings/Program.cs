

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string b = Console.ReadLine();
    string a = "";

    a += b[0];


    for (int j = 1; j < b.Length; j += 2)
    {
        a += b[j];
    }

    Console.WriteLine(a);
}