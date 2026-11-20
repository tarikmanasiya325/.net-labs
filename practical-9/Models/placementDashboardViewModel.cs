namespace PlacementDashboard.Models;
public sealed record StudentPlacementViewModel(
string EnrollmentNo,
string StudentName,
string Department,
bool IsPlaced,
string? CompanyName,
string? JobRole,
decimal? PackageLpa);
public sealed record CompanyPlacementViewModel(
string CompanyName,
string StudentName,
string EnrollmentNo,
string JobRole,
decimal PackageLpa);
public sealed record DashboardViewModel(
int TotalStudents,
int PlacedStudents,
int NotPlacedStudents,
decimal PlacementPercentage,
decimal HighestPackageLpa,
IReadOnlyList<StudentPlacementViewModel> Students);