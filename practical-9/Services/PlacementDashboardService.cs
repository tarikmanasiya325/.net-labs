using PlacementDashboard.Models;
namespace PlacementDashboard.Services;
public sealed class PlacementDashboardService
{
    private static readonly Student[] Students =
    [
    new(1, "CE001", "Aarav Patel", "CE", 2026, true),
new(2, "CE002", "Diya Shah", "CE", 2026, true),
new(3, "CE003", "Krish Mehta", "CE", 2026, true),
new(4, "CE004", "Riya Joshi", "CE", 2026, false),
new(5, "CE005", "Arjun Desai", "CE", 2026, false),
new(6, "CE006", "Neha Trivedi", "CE", 2026, true),
new(7, "CE007", "Dev Patel", "CE", 2026, true),
new(8, "CE008", "Mira Shah", "CE", 2026, false)
    ];
    private static readonly Placement[] Placements =
    [
    new(1, 1, "TCS", "System Engineer", 3.60m),
new(2, 2, "Infosys", "Systems Engineer", 4.00m),
new(3, 3, "Wipro", "Project Engineer", 3.50m),
new(4, 6, "TCS", "Assistant System Engineer", 3.60m),
new(5, 7, "Pinnacle IIT", "Software Developer", 6.00m)
    ];
    public DashboardViewModel GetDashboard()
    {
        var placementsByStudentId = Placements.ToDictionary(placement =>
        placement.StudentId);
        var studentRows = Students
        .Select(student =>
        {
            placementsByStudentId.TryGetValue(student.StudentId, out var
    placement);
            return new StudentPlacementViewModel(
    student.EnrollmentNo,
    student.StudentName,
    student.Department,
    student.IsPlaced,
    placement?.CompanyName,
    placement?.JobRole,
    placement?.PackageLpa);
        })
        .ToArray();
        var placedCount = Students.Count(student => student.IsPlaced);
        return new DashboardViewModel(
        Students.Length,
        placedCount,
Students.Length - placedCount,
Students.Length == 0 ? 0 : (decimal)placedCount * 100 / Students.Length,
Placements.Length == 0 ? 0 : Placements.Max(placement =>
placement.PackageLpa),
studentRows);
    }
    public IReadOnlyList<CompanyPlacementViewModel> GetCompanies()
    {
        var studentsById = Students.ToDictionary(student => student.StudentId);
        return Placements
        .Select(placement =>
        {
            var student = studentsById[placement.StudentId];
            return new CompanyPlacementViewModel(
    placement.CompanyName,
    student.StudentName,
    student.EnrollmentNo,
    placement.JobRole,
    placement.PackageLpa);
        })
        .ToArray();
    }
    private sealed record Student(
    int StudentId,
    string EnrollmentNo,
    string StudentName,
    string Department,
    int PassingYear,
    bool IsPlaced);
    private sealed record Placement(
    int PlacementId,
    int StudentId,
    string CompanyName,
    string JobRole,
    decimal PackageLpa);
}