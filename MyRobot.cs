using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_OTUS_
{
    internal class MyRobot : IRobot
    {
        List<string> list = new List<string>() { "корпус", "колеса", "датчики", "руки", "процессор" };
        public List<string> GetComponents()
        {
            return list;
            //throw new NotImplementedException();
        }

        public string GetInfo()
        {
            return "публичный секрет";
            //throw new NotImplementedException();
        }

        public string GetRobotType()
        {
            return "R2D2";
            //throw new NotImplementedException();
        }
    }
}
