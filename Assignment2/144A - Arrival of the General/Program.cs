

var n = int.Parse(Console.ReadLine());
var heights = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

var max = heights.Max();
var min = heights.Min();
var max_index = Array.IndexOf(heights,max);
var min_index = Array.LastIndexOf(heights,min);

int moves = max_index + (n - 1 - min_index);

if (max_index > min_index)
{
    moves--;
}

Console.WriteLine(moves);