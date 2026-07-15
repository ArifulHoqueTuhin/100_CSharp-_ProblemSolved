

int t = int.Parse(Console.ReadLine());
string correctName = "Timur";

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    if (n == 5)
    {
        char[] sArr = s.ToCharArray();
        Array.Sort(sArr);

        char[] correctArr = correctName.ToCharArray();
        Array.Sort(correctArr);

        if (new string(sArr) == new string(correctArr))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("NO");
    }

}