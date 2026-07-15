

var test = int.Parse(Console.ReadLine());
int count = 0;
var item = Console.ReadLine().Split(' ').Select(x => (int.Parse(x))).ToList();
var max = item[0];
var min = item[0];

for (int i = 1; i < item.Count; i++)
{
    if (item[i] > max)
    {
        count++;
        max = item[i];
    }
    if (item[i] < min)
    {
        count++;
        min = item[i];
    }
}

Console.WriteLine(count);


