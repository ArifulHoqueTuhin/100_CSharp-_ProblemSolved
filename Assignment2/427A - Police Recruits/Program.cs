
var test = int.Parse(Console.ReadLine());

var collection = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

int officers = 0;
int untreated = 0;

foreach (var item in collection)
{
    if (item == -1)
    {
       if (officers > 0)
        {
            officers--;
        }
       else
        {
            untreated++;
        }
    }
    else
    {
        officers += item;
    }
}


Console.WriteLine(untreated);