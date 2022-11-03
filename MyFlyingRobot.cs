using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_OTUS_
{
    public class MyFlyingRobot : IFlyingRobot
    {
        List<string> list = new List<string>() { "реактор", "2 ноги", "2 руки", "корпус", "шлем"};
        public List<string> GetComponents()
        {
            return list;
            //throw new NotImplementedException();
        }

        public string GetInfo()
        {
            return "MARK3";
            //throw new NotImplementedException();
        }      

        string IFlyingRobot.GetRobotType()
        {
            return "I am a flying robot";
            //throw new NotImplementedException();
        }

        string IRobot.GetRobotType()
        {
            return "I am a simple robot";
        }

        public string GetRobotType()
        {
            return "I am IRON MAN!";
        }
    }
}
