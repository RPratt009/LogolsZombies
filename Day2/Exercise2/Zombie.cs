using System;


namespace Exercise2{
    public class Person{
        public int  DistanceTraveled{get;set;}
        public string Name{ get; set;}
        public Person(){
            Console.WriteLine("A new person has been created. ");
        } 

        public void Walk(int minutes){
            DistanceTraveled = DistanceTraveled + CalculateDistance(minutes);
        }
        private  int CalculateDistance(int a){
            return a*2;
        }

    }
}