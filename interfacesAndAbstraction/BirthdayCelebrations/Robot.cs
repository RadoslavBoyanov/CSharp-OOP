namespace BirthdayCelebrations
{
    public class Robot : IRobot
    {
        public Robot(string model, string idRobot)
        {
            Model = model;
            IdRobot = idRobot;
        }
        public string Model { get; }
        public string IdRobot { get; }
    }
}
