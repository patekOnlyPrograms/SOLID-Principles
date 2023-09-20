namespace SOLID_Principles;

public class PersonDataCapture
{
    public static Person Capture()
    {
        Person person = new Person();
        
        Console.WriteLine("What is your first name: ");
        person.FirstName = Console.ReadLine();
        
        
        Console.WriteLine("What is your last name: ");
        person.LastName = Console.ReadLine();

        return person;
    }
}