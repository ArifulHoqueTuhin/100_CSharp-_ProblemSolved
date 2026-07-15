// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string input = Console.ReadLine();
input = input.ToLower();
string resutl = "";

for (int i = 0; i < input.Length; i++)
{
    if (input[i] != 'a' &&
   input[i] != 'e' &&
   input[i] != 'i' &&
   input[i] != 'o' &&
   input[i] != 'u' &&
   input[i] != 'y')
    {
        resutl += "." + input[i];
    }
}

Console.WriteLine(resutl);
