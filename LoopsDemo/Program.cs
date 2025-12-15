namespace LoopsDemo;

class Program
{
    static void Main(string[] args)
    {
        // while loop
        Console.WriteLine("while loop:");

        // var cont = "yes";
        //
        // while (cont == "yes")
        // {
        //     Console.WriteLine("Continue? (type 'yes' or 'no')");
        //     cont = Console.ReadLine();
        // }

        // var number = 0;
        //
        // while (number <= 5)
        // {
        //     Console.WriteLine(number);
        //     number++;
        // }
        // a while loop may never run because the condition may never even be met. asks the question first
        
        // do-while loop
        Console.WriteLine("do-while loop:");

        // var otherNumber = 10;
        //
        // do
        // {
        //     Console.WriteLine(otherNumber);
        //     otherNumber++;
        // } while (otherNumber <= 5);
        // a do-while loop executes something first and then checks for the condition. It at least runs once
        
        // for loop
        Console.WriteLine("for loop:");

        // for (int i = 0; i <= 5; i++)
        // {
        //     Console.WriteLine(i);
        // }
        //
        // Console.WriteLine("-----");
        //
        // for (var i = 10; i >= 1; i--)
        // {
        //     Console.WriteLine(i);
        // }
        
        // foreach loop
        Console.WriteLine("foreach loop:");

        var numbers = new int[] { 22, 3, 4, 66, 7, 88 };

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}