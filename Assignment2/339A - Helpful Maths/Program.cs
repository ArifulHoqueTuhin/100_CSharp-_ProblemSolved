// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string input = Console.ReadLine();
string[] array = input.Split("+");
Array.Sort(array);

for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1)
    {
        Console.Write($"{array[i]}");
    }
    else
    {
        Console.Write($"{array[i]}+");
    }
}

Console.WriteLine();

