using System.Text.RegularExpressions;

namespace SearchA;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Regex regex = new Regex("[aA]");
        MatchCollection matches = regex.Matches(input);

        if (matches.Count > 0)
        {
            Console.WriteLine($"A quantidade de As encontrado na frase é {matches.Count}");
        }
        else
        {
            Console.WriteLine("A frase não contem nenhum 'A'.");
        }
    }
}