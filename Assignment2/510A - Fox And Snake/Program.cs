

var table = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

var r = table[0];
var c = table[1];
bool right = true;

for (int i = 1; i <= r; i++)
{
    if (i % 2 != 0)
    {
        for (int j = 1; j <= c; j++)
        {
            Console.Write("#");
        }

        Console.WriteLine();
    }

    else
    {
        if (right == true)
        {
            for (int j = 1; j <= c; j++)
            {
                if (j == c)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
                right = false;
            }

            Console.WriteLine();
        }

        else
        {
            for (int j = 1; j <= c; j++)
            {
                if (j == 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }

                right = true;
            }
            Console.WriteLine();
        }
    }
}
