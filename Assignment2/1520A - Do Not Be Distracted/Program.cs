

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int l = int.Parse(Console.ReadLine());
    string str = Console.ReadLine();

    List<char> list = new List<char>();
    list.Add(str[0]);
    
    for (int j = 0; j < l - 1; j++)
    {
        if (str[j] != str[j + 1])
        {
            list.Add(str[j + 1]);
        }
    }

    bool similar = false;
    
    for (int j = 0; j < list.Count - 1; j++)
    {
        for (int k = j + 1; k < list.Count; k++)
        {
            if (list[j] == list[k])
            {
                similar = true;
                break;
            }
        }
        if (similar) break;
    }

    Console.WriteLine(similar ? "NO" : "YES");
}
