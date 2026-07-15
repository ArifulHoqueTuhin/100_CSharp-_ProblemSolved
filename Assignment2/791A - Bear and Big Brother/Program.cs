// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string input = Console.ReadLine();
string[] arry = input.Split(" ");

int a = int.Parse(arry[0]);
int b = int.Parse(arry[1]);
int w1 = a;
int w2 = b;
int count = 0;

while(w1 <= w2)
{
    w1 *= 3;
    w2 *= 2;
    count++;

}

Console.WriteLine(count);