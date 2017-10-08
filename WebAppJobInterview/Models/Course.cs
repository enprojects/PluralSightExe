namespace WebAppJobInterview.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual Student Student { get; set; }
    }
}