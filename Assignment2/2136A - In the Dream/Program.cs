

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);
    int d = int.Parse(input[3]);

    int firstHalfRiOI = a;
    int firstHalfKDOI = b;
    int secondHalfRiOI = c - a;
    int secondHalfKDOI = d - b;

    bool ok = CheckHalf(firstHalfRiOI, firstHalfKDOI)
           && CheckHalf(secondHalfRiOI, secondHalfKDOI);

    Console.WriteLine(ok ? "YES" : "NO");
}


static bool CheckHalf(int x, int y)
{

    int big = Math.Max(x, y);
    int small = Math.Min(x, y);

    return big <= 2 * (small + 1);
}