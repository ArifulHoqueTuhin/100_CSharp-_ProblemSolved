// See https://aka.ms/new-console-template for more information

var input = Console.ReadLine();
char[] arr = input.ToCharArray();
int a = 0;
int b = 0;
string result = "";

for (int i = 0; i < arr.Length; i++)
{
    if (Char.IsUpper(arr[i]))
    {
        a++;
    }
    else
    {
        b++;
    }
}

if (a > b)
{
    result = input.ToUpper();
    Console.WriteLine(result);  
}
else if (b > a)
{
    result = input.ToLower();
    Console.WriteLine(result);
}
else
{
    result = input.ToLower();
    Console.WriteLine(result);   
}