namespace Group4_IT3045_FinalProject.Models
{
    public class Person
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Major { get; set; }
        public string Year { get; set; }

        public Person() { }
        public Person(int Id, string fullname, DateTime birthdate, string major, string year)
        {
            id = Id;
            FullName = fullname;
            BirthDate = birthdate;
            Major = major;
            Year = year;
        }
    }
}
