// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string input1 = Console.ReadLine();
input1 = input1.ToLower();

string input2 = Console.ReadLine();
input2 = input2.ToLower();

if (input1.Length == input2.Length && (input1.Length >= 1 && input1.Length <= 100))
{
    int result = String.Compare(input1, input2);

    Console.WriteLine(result);
}







