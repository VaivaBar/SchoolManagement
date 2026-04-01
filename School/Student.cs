
public class Student : Person
{
    public string StudentId { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;
    public double GPA { get; set; }
    public int EnrolmentYear { get; set; }
    public override string GetRole()
    {
       return "Student";
    }

    public override string GetProfile()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Birthday: {Birthday}, Email: {Email}, StudentId: {StudentId}, " + 
               $"Program: {Program}, GPA: {GPA}, EnrolmenYear: {EnrolmentYear}";
    }
}