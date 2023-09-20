namespace LiskovSubstitutionPrinciple.TypesOfEmployees;

public interface IManager : IEmployee
{
    void GeneratePerformanceReview();
}