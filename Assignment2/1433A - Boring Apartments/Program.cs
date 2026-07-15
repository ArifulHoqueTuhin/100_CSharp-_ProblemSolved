

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string s = Console.ReadLine().Trim();
    int d = s[0] - '0';
    int k = s.Length;

    int answer = (d - 1) * 10 + (k * (k + 1)) / 2;
    Console.WriteLine(answer);
}
