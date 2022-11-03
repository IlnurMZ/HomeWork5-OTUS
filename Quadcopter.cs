using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork5_OTUS_
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components = new List<string>() { "rotor1", "rotor2", "rotor3", "rotor4" };
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents() => _components;       

        public string GetInfo()
        {
            throw new NotImplementedException();
            //return "реализация GetInfo";
        }

        string IChargeable.GetInfo()
        {
            throw new NotImplementedException();
            //return "реализация IChargeable.GetInfo";
        }

        string IRobot.GetInfo()
        {
            throw new NotImplementedException();
            //return "реализация IRobot.GetInfo";
        }

        public string GetRobotType()
        {
            throw new NotImplementedException();
            //return "реализация GetRobotType";
        }

        string IFlyingRobot.GetRobotType()
        {
            throw new NotImplementedException();
            //return "реализация IFlyingRobot.GetRobotType";
        }

        string IRobot.GetRobotType()
        {
            throw new NotImplementedException();
            //return "реализация IRobot.GetRobotType";
        }

    }
}
