﻿using System;

namespace Exercise2
{
       
    class Program
    {

        static void Main(string[] args)
        {
Zombie john =new Zombie();
 Human joe = new Human();
joe.Name="Joe";
john.Name="Joe";
joe.Walk(5);
john.Walk(5);
Console.WriteLine(joe.Name +" distance "+ joe.DistanceTraveled+" and then "+john.Name +" distance "+ john.DistanceTraveled);
       /* Person variable= new Person();
        variable.Name="Josh";
        string objectName=variable.Name;
        variable.DistanceTraveled = 100;
        variable.Walk(200);
        //Console.WriteLine(variable.Name+ " is the property value and "+ objectName+ " is the setting of variable by the property name "+ variable.DistanceTraveled +" miles traveled");
        Console.WriteLine(variable.Name +" could walk "+variable.DistanceTraveled+" Miles, and then could walk "+variable.DistanceTraveled+" more.");
         */
        }
    }
}
