namespace OpenClosedPrinciple;

public class ExecutiveAccounts : IAccounts
{
    public Employee Create(IPerson person)
    {
        Employee output = new Employee();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName}.{person.LastName}@acmecorp.com";
        output.IsExecutive = true;
        output.IsManager = true;

        return output;
    }
}