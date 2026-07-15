

int[] colors = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

HashSet<int> unique_color = new HashSet<int>();

foreach (var color in colors)
{
    unique_color.Add(color);
}

var count = unique_color.Count;
var res = colors.Length - count;
Console.WriteLine(res);
