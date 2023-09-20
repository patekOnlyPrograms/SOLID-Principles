namespace SOLID_Principles;

public class AccountGenerator
{
    public static void CreateAccount(Person personObject)
    {
        Console.WriteLine(
            $"Your username is " +
            $"{personObject.FirstName.Substring(0,2)}" +
            $"{personObject.LastName}");
    }
    
}