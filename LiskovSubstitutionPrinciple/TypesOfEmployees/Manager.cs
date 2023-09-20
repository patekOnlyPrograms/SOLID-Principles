namespace LiskovSubstitutionPrinciple.TypesOfEmployees;

public class Manager : Employee
{
    public override void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 19.75M;

        Salary = baseAmount + (rank * 4);
    }

    public void GeneratePerformanceReview()
    {
        // Simulate reviewing a direct report
        Console.WriteLine("I'm reviewing a direct report's performance.");
    }
}