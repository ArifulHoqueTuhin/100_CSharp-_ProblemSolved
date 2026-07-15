
var t = int.Parse(Console.ReadLine());


for (int i = 0; i < t; i++)
{
    var size = int.Parse(Console.ReadLine());
    var arr = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
    for (int j = 0; j < arr.Count; j++)
    {
        List<int> list = new List<int>();
        list.Add(arr[j]);
        arr.Remove(arr[j]);
        var a = list.Sum();
       var b = arr.Sum();

       if ( a % 2 == 0 && b % 2 == 0 || a % 2 != 0 && b % 2 != 0)
        {
            Console.WriteLine("YES");
            break;
        }

       else if (a % 2 == 0 && b % 2 != 0 || a % 2 != 0 && b % 2 == 0)
        {
            Console.WriteLine("NO");
            break;
        }
       else           
            continue;
    }

  
}