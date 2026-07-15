

string s = Console.ReadLine();
string result = "";

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '.')
    {
        result += "0";
    }
    else if (s[i] == '-')
    {
        if (i + 1 < s.Length && s[i + 1] == '.')
        {
            result += "1";
            i++;
        }
        else if (i + 1 < s.Length && s[i + 1] == '-')
        {
            result += "2";
            i++; 
        }
    }
}

Console.WriteLine(result);
    
