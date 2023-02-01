namespace BirthdayCelebrations
{
    public class Citizen : ICitizens
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthday { get; set; }
    }
}
