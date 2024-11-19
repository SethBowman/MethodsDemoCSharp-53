namespace MethodsDemoCSharp_53;

class Program
{
    //create customs methods here
    static void Main(string[] args)
    {
        //Void return type
        Console.WriteLine("Hello, World!");
        
        //string return type
        //string response = Console.ReadLine();

        //Console.WriteLine($"Hello, {response}");
        
        //Call a method (use a method)
        GreetPerson("Seth");
        GreetPerson("Miah");

        int twoPlusTwo = AddTwoInts(2, 2);
        Console.WriteLine(twoPlusTwo);
    }
    
    //or create custom methods here
    
    //method definition (create a method)
    //Pascal casing for Method names
    public static void GreetPerson(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static int AddTwoInts(int numOne, int numTwo)
    {
        // int sum = numOne + numTwo;
        // return sum;
        return numOne + numTwo;
    }
}
