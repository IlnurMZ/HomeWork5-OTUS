using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_OTUS_
{
    public interface IFlyingRobot : IRobot
    {
        new string GetRobotType() => "I am a flying robot.";
    }
}
