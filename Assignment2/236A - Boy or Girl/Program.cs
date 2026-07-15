// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string input = Console.ReadLine();
char[] chars = input.ToCharArray();

Array.Sort(chars);

int count = 0;
int result = 0;

for (int i = 0; i < input.Length - 1; i++)
{
    if (chars[i] == chars[i + 1])
    {
        count++;
    }

     result = input.Length - count;
}

if (result % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}


