using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork5_OTUS_
{
    public class MyCharge : IChargeable
    {
        public string GetInfo()
        {
            return "some info";
            //throw new NotImplementedException();
        }    
        public void Charge()
        {
            Console.WriteLine("SuperCharging...");
            Thread.Sleep(2000);
            Console.WriteLine("Charged!");
            //throw new NotImplementedException();
        }
    }
}
