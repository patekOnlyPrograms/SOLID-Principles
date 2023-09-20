namespace OpenClosedPrinciple;

public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    IAccounts AccountProcessor { get; set; }
}