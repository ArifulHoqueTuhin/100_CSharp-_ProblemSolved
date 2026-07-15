// See https://aka.ms/new-console-template for more information

var input = Console.ReadLine();

string word = "hello";

int j = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == word[j])
    {
        j++;

        if (j == word.Length)
            break;
    }

}

if  (j == word.Length)
{
    Console.WriteLine("YES");
}

else
{
    Console.WriteLine("NO");
}