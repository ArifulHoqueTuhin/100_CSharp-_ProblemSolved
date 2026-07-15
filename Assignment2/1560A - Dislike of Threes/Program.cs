

int t = int.Parse(Console.ReadLine()); 

for (int i = 0; i < t; i++)
{
    int k = int.Parse(Console.ReadLine());
    int count = 0;
    int num = 0;

    while (count < k)
    {
        num++;

        if (num % 3 == 0 || num % 10 == 3)
        {
            continue;
        }

         count++;
    }

    Console.WriteLine(num);
}