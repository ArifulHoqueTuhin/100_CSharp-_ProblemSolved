

int t = int.Parse(Console.ReadLine());

for (int test = 0; test < t; test++)
{
    char[,] grid = new char[8, 8];

    for (int i = 0; i < 8; i++)
    {
        string line = Console.ReadLine();
        for (int j = 0; j < 8; j++)
        {
            grid[i, j] = line[j];
        }
    }

    string word = "";


    for (int col = 0; col < 8; col++)
    {
        word = "";
        for (int row = 0; row < 8; row++)
        {
            if (grid[row, col] != '.')
                word += grid[row, col];
        }


        if (word.Length > 0)
            break;
    }

    Console.WriteLine(word);
}
