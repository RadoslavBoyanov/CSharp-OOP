using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
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
