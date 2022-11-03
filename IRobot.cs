using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_OTUS_
{
    public interface IRobot
    {
        string GetInfo();

        List<string> GetComponents();

        string GetRobotType() => "I am a simple robot.";       
    }
}
