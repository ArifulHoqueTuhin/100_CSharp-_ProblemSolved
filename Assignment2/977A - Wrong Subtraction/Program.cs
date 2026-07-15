// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var input = Console.ReadLine();
string[] arr = input.Split(" ");
int a = int.Parse(arr[0]);
int b = int.Parse(arr[1]);

for (int i = 0; i < b; i++)
{
    if( a%10  == 0)
    {
        a = a / 10;        
    }

    else
    {
        a--;
    }
}

Console.WriteLine(a);