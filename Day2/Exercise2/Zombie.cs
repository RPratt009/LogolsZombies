using System;


namespace Exercise2{
   public  sealed class Zombie : Person
   {
       
        public override void Walk(int minutes){
            DistanceTraveled = DistanceTraveled + CalculateDistance(minutes);
        }
          private  int CalculateDistance(int a){
            return a/4;
        }

    }
}