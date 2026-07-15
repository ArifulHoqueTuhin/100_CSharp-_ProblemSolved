// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int r = 5;
int c = 5;
int row = 0;
int col = 0;
int rValue = 0;
int cValue = 0;
int outPut = 0;
int[,] matrix = new int[r, c];

for (int i = 0; i < r; i++)
{

    string[] line = Console.ReadLine().Split(" ");
   
    for (int j = 0; j < c; j++)
    {
        int value = int.Parse(line[j]);
        matrix[i, j] = value;

        if (value == 1)
        {
             row = i;
             col = j;    

            if (row > 2 )
            {
                rValue = row - 2;
            }

            else if (row < 2 )
            {
                rValue = 2 - row;
            }
            else
            {
                rValue = 0;
            }

            if (col > 2)
            { 
                cValue = col - 2;
            }

            else if (col < 2)
            {
                cValue = 2 - col;
            }

            else
            {
                cValue = 0;
            }

            outPut = rValue + cValue;
        }

       
    }
 
}

Console.WriteLine(outPut);




