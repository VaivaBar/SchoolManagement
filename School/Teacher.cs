public class Teacher : Staff
{
    public string SubjectArea { get; set; } = string.Empty;
    public List<string> CoursesTaught { get; set; } = new List<string>();
    public string TeachingRating {get; set; } = string.Empty;

    public override string GetRole()
    {
        return "Teacher";
    }
    public override string GetProfile()
    {
        return $"{base.GetProfile()}, Subject Area: {SubjectArea}, Teaching Rating: {TeachingRating}";
    }
}