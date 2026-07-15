


int x = int.Parse(Console.ReadLine());
int count = 0;

while (x > 0)
{
    count += x & 1; // check last bit
    x >>= 1;        // shift right
}

Console.WriteLine(count);