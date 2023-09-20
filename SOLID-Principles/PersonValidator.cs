namespace SOLID_Principles;

public class PersonValidator
{
    public static bool Validate(Person personObject)
    {
        if (string.IsNullOrWhiteSpace(personObject.FirstName))
        {
            StandardMessages.DisplayValidationError("First Name");
            return false;
        }
        
        if (string.IsNullOrWhiteSpace(personObject.LastName))
        {
            StandardMessages.DisplayValidationError("Last Name");
            return false;
        }

        return true;
    }
}