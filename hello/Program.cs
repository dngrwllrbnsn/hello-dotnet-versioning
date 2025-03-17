namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine("This is your number: " + num);

        //if number is divisible by 2--modulo(%) means no remainder
        if(num%2==0){
            Console.WriteLine(num + " is even!");
        }
        else{
            Console.WriteLine(num + " is odd!");
        }

    }
}
