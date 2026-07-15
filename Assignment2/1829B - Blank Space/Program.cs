

var t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var l = int.Parse(Console.ReadLine());
    var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
    int count = 0;
    List<int> list = new List<int>();

    for (int j = 0; j < arr.Count; j++)
    {
        if (arr[j] == 0)
        {
            count++;
            list.Add(count);
        }

        if (arr[j] == 1)
        {
            count = 0;
            list.Add(count);
        }
    }

    var res = list.Max();
    Console.WriteLine(res);


}