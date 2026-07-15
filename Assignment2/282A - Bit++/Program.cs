// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int range = int.Parse(Console.ReadLine());
int x = 0;
if (range>=1 && range<=150)
{
    for(int i=0; i<range; i++)
    {
        string statement = Console.ReadLine();
        if (statement == "X++" || statement == "++X")
        {
            x += 1;
        }
        else if (statement == "--X" || statement == "X--")
        {
            x -= 1;
        }

        else
        {
            Console.WriteLine("invalid statement");
        }
    }
    Console.WriteLine(x);
}
else
{
    Console.WriteLine("invalid range");
}