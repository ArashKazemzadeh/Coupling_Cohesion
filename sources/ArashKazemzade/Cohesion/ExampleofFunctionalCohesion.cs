// Example of Functional Cohesion
// EmployeeManagementModule.cs

public class EmployeeManagementModule
{
    // All elements contribute to a single well-defined business function
    public void HireEmployee(Employee employee) { /* implementation */ }
    public void UpdateEmployeeDetails(Employee employee) { /* implementation */ }
    public void CalculateSalary(Employee employee) { /* implementation */ }
}
