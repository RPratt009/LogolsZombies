using System;

namespace Exercise2
{
       
    class Program
    {

        static void Main(string[] args)
        {
        Person variable= new Person();
        variable.Name="Josh";
        string objectName=variable.Name;
        variable.DistanceTraveled = 100;
        variable.Walk(200);
        //Console.WriteLine(variable.Name+ " is the property value and "+ objectName+ " is the setting of variable by the property name "+ variable.DistanceTraveled +" miles traveled");
        Console.WriteLine(variable.Name +" could walk "+variable.DistanceTraveled+" Miles, and then could walk "+variable.DistanceTraveled+" more.");
        }
    }
}
