namespace IMC.Entities
{
    internal class User
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public User(string? name, string gender, double weight, double height)
        {
            Name = name;
            Gender = gender;
            Weight = weight;
            Height = height;
        }

       
    }
}
