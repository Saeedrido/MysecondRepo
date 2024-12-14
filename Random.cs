using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

bool proceed = false;
while (!proceed)
{
    try
    {
        Console.WriteLine("Enter your String length: ");
        int length = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter true/false to generate only alphabet: ");
        bool includeAlphabets = bool.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter true/false to generate alphanumeric value: ");
        bool includeNumbers = bool.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter true/false to add characters: ");
        bool includeSpecialCharacters = bool.Parse(Console.ReadLine()!);
         proceed = true;

        RandomMove(length, includeAlphabets, includeNumbers, includeSpecialCharacters);
       
    }
    catch (FormatException err)
    {
        Console.WriteLine("Please enter only true/false!");
        Console.WriteLine($"Error: {err.Message}");
    }
    catch (Exception err)
    {
        Console.WriteLine("Something went wrong");
        Console.WriteLine($"Error: {err.Message}");
    }
}

static void  RandomMove(int length, bool includeAlphabets, bool includeNumbers, bool includeSpecialCharacters)
{
    StringBuilder combinePool = new StringBuilder();

    string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

    string Numbers = "0123456789";

    string specialCharacters = "!@#$%^&*()-_=+[]{};`:'\",.<>?/|\\~";

    if (includeAlphabets)
    {
        combinePool.Append(alphabets);
    }
    if (includeNumbers)
    {
        combinePool.Append(Numbers);
    }
    if (includeSpecialCharacters)
    {
        combinePool.Append(specialCharacters);
    }

    Random random = new Random();
    StringBuilder result = new StringBuilder();

    for (int i = 0; i < length; i++)
    {
        int ans = random.Next(combinePool.Length);
        result.Append(combinePool[ans]);

    }
    Console.WriteLine(result);
}






