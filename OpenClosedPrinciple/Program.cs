namespace OpenClosedPrinciple;

public class Program
{
    public static void Main(string[] args)
    {
        List<IPerson> applicants = new List<IPerson>()
        {
            new Person { FirstName = "Tim", LastName = "Corey" },
            new Manager { FirstName = "John", LastName = "Dylan"},
            new Executive() { FirstName = "Nancy", LastName = "Roman"},
        };

        List<Employee> employees = new List<Employee>();
        

        foreach (var person in applicants)
        {
            employees.Add(person.AccountProcessor.Create(person));
        }
        
        foreach (var person in employees)
        {
            Console.WriteLine($"{person.FirstName}{person.LastName}: {person.EmailAddress}" + 
                              $" Is Manager: {person.IsManager}" +
                              $" Is Executive: {person.IsExecutive} ");
        }
        
    }
}