

var t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    var str = Console.ReadLine();
    if (str == "abc")
    {
        Console.WriteLine("YES");
        continue;
    }

    else
    {

        char[] chars = str.ToCharArray();

        if (chars[0] == 'a')
        {
            var temp = chars[1];
            chars[1] = chars[2];
            chars[2] = temp;

            var res = string.Join("", chars);

            if (res == "abc")
            {
                Console.WriteLine("YES");
                continue;
            }
            else
            {
                Console.WriteLine("NO");
                continue;
            }

        }

        if (chars[0] == 'b')
        {
            var temp = chars[0];
            chars[0] = chars[1];
            chars[1] = temp;

            var res = string.Join("", chars);

            if (res == "abc")
            {
                Console.WriteLine("YES");
                continue;
            }
            else
            {
                Console.WriteLine("NO");
                continue;
            }


        }

        if (chars[0] == 'c')
        {
            var temp = chars[0];
            chars[0] = chars[2];
            chars[2] = temp;

            var res = string.Join("", chars);

            if (res == "abc")
            {
                Console.WriteLine("YES");
                continue;
            }
            else
            {
                Console.WriteLine("NO");
                continue;
            }


        }
    }

}


