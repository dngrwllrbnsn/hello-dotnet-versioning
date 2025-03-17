namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine("This is your number: " + num);
    }
}
