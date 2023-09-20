namespace SOLID_Principles;

public class StandardMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to my application");
    }

    public static void EndApplication()
    {
        Console.ReadKey();
    }

    public static void DisplayValidationError(string fieldName)
    {
        Console.WriteLine($"You did not give us a valid {fieldName}!");
    }
}