

var test_case = int.Parse(Console.ReadLine());
List<string> strings = new List<string>();
int res = 0;

for (int i = 0; i < test_case; i++)
{
    var type = Console.ReadLine();
    strings.Add(type);
}

foreach (string type in strings)
{
    if (type == "Tetrahedron")
    {
        res += 4;
    }
    if (type == "Cube")
    {
        res += 6;
    }
    if (type == "Octahedron")
    {
        res += 8;
    }
    if (type == "Dodecahedron")
    {
        res += 12;
    }
    if (type == "Icosahedron")
    {
        res += 20;
    }
}

Console.WriteLine(res);