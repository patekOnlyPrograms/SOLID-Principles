namespace OpenClosedPrinciple;

public class Accounts : IAccounts
{
    public Employee Create(IPerson person)
    {
        Employee output = new Employee();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com";


        return output;
    }

}