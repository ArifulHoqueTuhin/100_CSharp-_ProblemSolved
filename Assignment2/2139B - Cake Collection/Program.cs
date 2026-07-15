

int test = int.Parse(Console.ReadLine());
long res = 0;
for (int i = 0; i < test; i++)
{
    int[] int1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    int m = int1[0];
    long n = int1[1];
    int[] int2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    Array.Sort(int2);


    res = 0;
    
    int j = int2.Length - 1;


         while (n >= 0 )
        {
            res += int2[j] * n;
            n--;

        if ( n <= 0 )
        {
            Console.WriteLine(res);
            break;
        }
            j--;

            if (j < 0)
          {
            Console.WriteLine(res);
            break;
          }

        }

}