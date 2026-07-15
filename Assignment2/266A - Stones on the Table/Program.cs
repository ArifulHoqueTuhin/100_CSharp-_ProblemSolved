// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int input = int.Parse(Console.ReadLine());
string colour = Console.ReadLine();

int count = 0;

for (int i = 0; i < input - 1; i++) 
{
    if (colour[i] == colour[i + 1]) 
    {
        count++;
    }
}

Console.WriteLine(count);
