namespace Group4_IT3045_FinalProject.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public string Description { get; set; }

        public string Availability { get; set; }

        public Course() { }

        public Course(int courseID, string title, int credits, string description, string availability)
        {
            CourseID = courseID;
            Title = title;
            Credits = credits;
            Description = description;
            Availability = availability;
        }
    }
}
