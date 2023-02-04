namespace BirthdayCelebrations
{
    public class Pet : IPet
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; }
        public string Birthday { get; }
    }
}
