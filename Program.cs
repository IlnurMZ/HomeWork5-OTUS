using System;

namespace HomeWork5_OTUS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRobot r1 = new Quadcopter();            
            try
            {
                Console.WriteLine("IRobot: " + r1.GetInfo() + " "+ r1.GetRobotType());                
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Ошибка вызова метода IRobot");
            }
            foreach (var item in r1.GetComponents())
                Console.WriteLine(item + " ");                     
            Console.WriteLine("----------\n");


            IFlyingRobot r2 = new Quadcopter();            
            try
            {                
                Console.WriteLine("IFlyingRobot: " + r2.GetInfo() + " " + r2.GetRobotType());
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Ошибка вызова метода IFlyingRobot");
            }            
            foreach (var item in r2.GetComponents())            
                Console.WriteLine(item + " ");
            Console.WriteLine("----------\n");


            IChargeable r3 = new Quadcopter();            
            try
            {
                Console.WriteLine("IChargeable " + r3.GetInfo());                 
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Ошибка вызова метода IChargeable");
            }
            r3.Charge();
            Console.WriteLine("----------\n");

            Quadcopter q1 = new Quadcopter();
            try
            {                
                Console.WriteLine("Quadcopter: " + q1.GetInfo() + q1.GetRobotType());               
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Ошибка вызова метода Quadcopter");
            }
            q1.Charge();            
            foreach (var item in q1.GetComponents())
                Console.WriteLine(item + " ");    
            Console.WriteLine("----------\n");
        }
    }
}
