using System.Reflection.Metadata;

namespace SOLID_Principles;

public class Program
{
    public static void Main(string[] args)
    {
        StandardMessages.WelcomeMessage();

        Person person = PersonDataCapture.Capture();


        bool isUserValid = PersonValidator.Validate(person);

        if (isUserValid.Equals(false))
        {
            StandardMessages.EndApplication();
            return;
        }
        AccountGenerator.CreateAccount(person);
        StandardMessages.EndApplication();
    }
}