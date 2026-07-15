

var t = int.Parse(Console.ReadLine());
int res = 0;

for (int i = 0; i < t; i++)
{
    var l = int.Parse(Console.ReadLine());
    var array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
  
    if (array[0] != array[1] && array[0] != array[2])
    {
        res = 1;
    }

    else
    {

        for (int j = 0; j < array.Length; j++)
        {
            if (array[0] != array[j])
            {
                res = j + 1;
                break;
            }
        }
    }

    Console.WriteLine(res);
    
}


