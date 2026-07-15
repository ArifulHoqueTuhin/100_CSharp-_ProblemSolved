
//Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.



class Program
{
    static void Main()
    {
        Console.WriteLine(ReverseAndNot(123)); 
    }

    static string ReverseAndNot(int i)
    {
        string res = i.ToString();
        char[] re = res.Reverse().ToArray();
        string b = new string(re); 

        return b + res;
    }
}
