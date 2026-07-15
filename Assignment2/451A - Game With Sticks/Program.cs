

var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
var n = nm[0];
var m  = nm[1];
int turn = 0;

while(n != 0 ||  m != 0)
{

    n--;
    m --;
    if ( n == 0 || m == 0 )
    {
        n = 0;
        m = 0;
    }

    turn++;
    
}

Console.WriteLine( turn % 2 != 0 ? "Akshat" : "Malvika");