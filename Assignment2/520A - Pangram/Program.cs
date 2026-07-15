
var test = int.Parse(Console.ReadLine());
var sentence = Console.ReadLine().ToLower().ToCharArray();
HashSet<char> words = new HashSet<char>();

foreach (var word in sentence)
{
    if (word >= 'a' && word <= 'z')
        words.Add(word);
}

if(words.Count() == 26)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}