public class UndergraduateStudent : Student

{    
    public string Major { get; set; } = string.Empty;
    public string Minor { get; set; } = string.Empty;
    public int TotalCredits { get; set; }

    public override string GetRole()
        {
        return base.GetRole();
        }

    public override string GetProfile()
        {
        return base.GetProfile();
        }
    public override string GetAcademicStanding()
    {
        string academicStanding = base.GetAcademicStanding();
        string courseLevel;

        if (TotalCredits < 30)
        {
            courseLevel = "Freshman";
        }
        else if (TotalCredits < 60)
        {
            courseLevel = "Sophmore";
        }
        else if (TotalCredits < 90)
        {
            courseLevel = "Junior";
        }
        else courseLevel = "Senior";

        return $"{academicStanding}, {courseLevel}";

    }
}
