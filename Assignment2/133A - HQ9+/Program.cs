// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string input = Console.ReadLine();

char[] arry = input.ToCharArray();
bool res = false;

for (int i = 0; i < arry.Length; i++)
{
    if (arry[i] == 'H' || arry[i] == 'Q' || arry[i] == '9')
    {
        res = true;
    }

}

if (res)
{
    Console.WriteLine("YES");
}

else
{
    Console.WriteLine("NO");
}