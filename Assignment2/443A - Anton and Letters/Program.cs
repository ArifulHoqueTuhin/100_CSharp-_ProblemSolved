

var line = Console.ReadLine();

var input = line.Trim('{', '}', ' ')
                .Split(',')
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrEmpty(x))  
                .ToList();


HashSet<string> output = new HashSet<string>(input);


Console.WriteLine(output.Count);