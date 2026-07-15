


var points = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
points.Sort();
int result = points[2] - points[0];
Console.WriteLine(result);