namespace Group4_IT3045_FinalProject.Models
{
    public class Cat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public string Personality { get; set; }

        public string Color { get; set; }

        public Cat(int id, string name, string breed, 
            string personality, string color)
        {
            Id = id;
            Name = name;
            Breed = breed;
            Personality = personality;
            Color = color;
        }

        public Cat() { }


    }
}
