

var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0];
int m = input[1];

var tasks = Console.ReadLine().Split().Select(int.Parse).ToArray();

long totalTime = 0;
int currentHouse = 1;

for (int i = 0; i < m; i++)
{
    if (tasks[i] >= currentHouse)
        totalTime += tasks[i] - currentHouse;
    else
        totalTime += n - (currentHouse - tasks[i]);

    currentHouse = tasks[i];
}

Console.WriteLine(totalTime);
