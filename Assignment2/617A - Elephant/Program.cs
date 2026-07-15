// See https://aka.ms/new-console-template for more information

var input = int.Parse(Console.ReadLine());
int  a = input / 5;
int b  = input % 5;

if (b < 5 && b != 0)
{
    a++;
}

Console.WriteLine(a);