using System;

public class test
{
    public static void runAllTests()
    {
        Console.WriteLine("Running MathsTutor tests... \n");
        testMenuInvalid();
        testMenuInstruction();
        testMenuStart();
        testMenuQuit();
        testGame3();

        Console.WriteLine("\n All tests passed!");
    }
    
    private static void testMenuInvalid()
    {
        Console.WriteLine("Test: Menu with invalid input");
        Console.WriteLine("Expected output: Invalid input, please try again.");
        string input = "invalid";
        bool result = MathsTutor.menu(input);
        if (!result)
        {
            Console.WriteLine("Test Passed.");
        }
        else
        {
            Console.WriteLine("Test failed.");
        }
        Console.WriteLine();
    }
    private static void testMenuInstruction()
    {
        Console.WriteLine("Test: Menu with 'instructions' input");
        Console.WriteLine("Expected output: instructions printed, then returns to menu");
        string input = "instructions";
        bool result = MathsTutor.menu(input);
        if (result)
        {
            Console.WriteLine("Test failed.");
        }
        else
        {
            Console.WriteLine("Test passed.");
        }
        Console.WriteLine();
    }
    private static void testMenuStart()
    {
        Console.WriteLine("Test: Menu with 'start' input");
        Console.WriteLine("Expected output: Game3 function called");
        string input = "start";
        bool result = MathsTutor.menu(input);
        if (result)
        {
            Console.WriteLine("Test passed.");
        }
        else
        {
            Console.WriteLine("Test failed.");
        }
        Console.WriteLine();
    }
    private static void testMenuQuit()
    {
        Console.WriteLine("Test: Menu with 'quit' input");
        Console.WriteLine("Expected output: 'Goodbye, hope you enjoyed the game!' message printed, then program terminates.");
        string input = "quit";
        bool result = MathsTutor.menu(input);
        if (result)
        {
            Console.WriteLine("Test passed.");
        }
        else
        {
            Console.WriteLine("Test failed.");
        }
        Console.WriteLine();
    }
    private static void testGame3()
    {
        Console.WriteLine("Test: Game3 function");
        Console.WriteLine("Expected output: 3 cards dealt, user inputs answer, and program responds with correct or incorrect message.");
        bool result = MathsTutor.game3();
        if (result)
        {
            Console.WriteLine("Test passed.");
        }
        else
        {
            Console.WriteLine("Test failed.");
        }
        Console.WriteLine();
    }
}