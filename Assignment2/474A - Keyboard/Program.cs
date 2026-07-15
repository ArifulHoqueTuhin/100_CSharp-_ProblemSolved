

string keyboard = "qwertyuiopasdfghjkl;zxcvbnm,./";

char direction = Console.ReadLine()[0];
string typed = Console.ReadLine();

char[] result = new char[typed.Length];

for (int i = 0; i < typed.Length; i++)
{
    int index = keyboard.IndexOf(typed[i]);

    if (direction == 'L')
    {
        // moved left → actual key is right
        result[i] = keyboard[index + 1];
    }
    else // 'R'
    {
        // moved right → actual key is left
        result[i] = keyboard[index - 1];
    }
}

Console.WriteLine(new string(result));