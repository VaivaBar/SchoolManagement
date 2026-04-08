public class GraduateStudent : Student
{
    public string ThesisTitle { get; set; } = string.Empty;
    public string Supervisor {get; set; } = string.Empty;
    public string ThesisSubmitted {get; set; } = string.Empty;

    public override string GetRole()
    {
        return "GraduateStudent";
    }

    public override string GetProfile()
    {
        return $"{base.GetProfile()}, Thesis Title: {ThesisTitle}, Supervisor: {Supervisor}, Thesis Submitted: {ThesisSubmitted}";
    }

    public override string GetAcademicStanding()
    {
        return $"{base.GetAcademicStanding()}, Thesis Submitted: {ThesisSubmitted}";
    }
}