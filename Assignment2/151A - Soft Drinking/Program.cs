

var items = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
List<int> list = new List<int>();
var n = items[0];
var k = items[1];
var l = items[2];
var c = items[3];
var d = items[4];
var p = items[5];
var nl = items[6];
var np = items[7];



var total_drink = (k * l) / nl;
list.Add(total_drink);
var total_lime = c * d;
list.Add(total_lime);
var salt = p / np;
list.Add(salt);

var min = list.Min();
var res = min / n;

Console.WriteLine(res);
