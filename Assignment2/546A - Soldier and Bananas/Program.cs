// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var input = Console.ReadLine();
string[] array = input.Split(" ");
int k = int.Parse(array[0]);
int n = int.Parse(array[1]);
int w = int.Parse(array[2]);
int sum = 0;
int result = 0;

for (int i = 1; i <= w; i++)
{
    sum += i * k;
}

if (sum > n)
{
    result = sum - n;
    Console.WriteLine(result);
}

else
{
    result = 0;
    Console.WriteLine(result);
}

