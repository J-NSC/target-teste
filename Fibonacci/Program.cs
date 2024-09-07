namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to check if it belongs to the Fibonacci sequence: ");
        int number = int.Parse(Console.ReadLine());

        bool belongs = BelongsToFibonacci(number);

        if (belongs)
        {
            Console.WriteLine($"The number {number} belongs to the Fibonacci sequence.");
        }
        else
        {
            Console.WriteLine($"The number {number} does NOT belong to the Fibonacci sequence.");
        }
    }

    static bool BelongsToFibonacci(int num)
    {
        if (num < 0)
            return false;

        int first = 0;
        int second = 1;

        while (first <= num)
        {
            if (first == num)
                return true;

            int temp = first;
            first = second;
            second = temp + second;
        }

        return false;
    }
}