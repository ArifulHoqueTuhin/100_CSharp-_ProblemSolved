// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string input = Console.ReadLine();
char[] chars = input.ToCharArray();
int count = 1;
bool dangerous = false;

for (int i = 0; i < chars.Length -1; i++)
{
    if (chars[i] != chars[i+1])
    {
        count = 1;
    }

    else
    {
        count++;
    }

    if (count >= 7)
    {
        dangerous = true;
        break;
    }
}

if (dangerous)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");

