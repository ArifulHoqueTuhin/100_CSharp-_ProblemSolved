

int t = int.Parse(Console.ReadLine()); 
string target = "codeforces"; 

for (int i = 0; i < t; i++)
{
    string s = Console.ReadLine(); 
    int diffCount = 0;

    for (int j = 0; j < 10; j++)
    {
        if (s[j] != target[j])
            diffCount++;
    }

    Console.WriteLine(diffCount);
}