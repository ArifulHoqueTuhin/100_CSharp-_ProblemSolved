

var test = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
var k = test[0];
var r = test[1];
int count = 1;

while (true)
{
    int total = k * count;

    if (total % 10 == 0 || total % 10 == r)
        break;

    count++;
}


Console.WriteLine(count);