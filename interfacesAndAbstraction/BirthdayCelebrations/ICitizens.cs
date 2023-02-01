using System.Reflection.Metadata;

namespace BirthdayCelebrations
{
    public interface ICitizens
    {
        public string Name { get; }
        public int Age { get;  }
        public string Id { get;  }
        public string Birthday { get; set; }
    }
}
