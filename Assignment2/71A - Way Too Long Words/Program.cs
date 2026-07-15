// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int range = int.Parse(Console.ReadLine());

if (range >= 1 && range <= 100)
{
    for (int i = 0; i < range; i++)
    {

        string word = Console.ReadLine();

        if (word.Length > 0 && word.Length <= 100)
        {

            if (word.Length > 10)
            {


                int length = word.Length;
                int mid = length - 2;
                char first = word[0];
                char last = word[length - 1];
                Console.WriteLine($"{first}{mid}{last}");

            }

            else
            {
                Console.WriteLine(word);
            }
        }
        else
        {
            Console.WriteLine("invalid word");
        }
    }


}

else
{
    Console.WriteLine("range is not valid");
}


