

var input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

bool color = false;

for (int i = 0; i < n; i++)
{
    var row = Console.ReadLine().Split();

    foreach (var item in row)
    {
        if (item == "C" || item == "M" || item == "Y")
        {
            color = true;
            break;
        }
    }
   
}

Console.WriteLine(color ? "#Color" : "#Black&White");