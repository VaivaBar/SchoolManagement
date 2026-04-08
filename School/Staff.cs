
public class Staff : Person
{
    public int EmployeeId {get; set; }
    public string Department {get; set; } = string.Empty;
    public double Salary {get; set; }
    public DateOnly HireDate { get; }
    public override string GetRole()
    {
        return "Staff";
    }

    public override string GetProfile()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Birthday: {Birthday}, Email: {Email}," +
        $"EmployeeId: {EmployeeId}, Department: {Department}, Salary: {Salary}, HireDate: {HireDate}";
    }

    public override string GetContactInfo()
    {
        return $"Email: {Email}, $Department: {Department}";
    }
}