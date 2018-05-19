using System;

namespace Exercise1 {
 class Program {
  private static string GetStatus(int health) {
   string alive = "Alive";
   string zombie = "Zombie";
   string dead = "Dead";
   string unknown = "Unknown";
   string text = " > Status: ";
   /*
   if (health == 1) {
    return text + alive;
   } else if (health == 2) {
    return text + zombie;
   } else if (health == 3) {
    return text + dead;
   } else {
    return text + unknown;
   }
   /*/
   //double sided to swap btwn if and switch faster
      switch (health) {
       case 1:
        return text + alive;
       case 2:
        return text + zombie;
       case 3:
        return text + dead;
       default:
        return text + unknown;
      }
   
  }
  static string CapFirst(string s) {//capitalize the first letter of the names
   char[] a = s.ToCharArray();
   a[0] = char.ToUpper(a[0]);
   return new string(a);
  }
  static void Main(string[] args) {
   int i = 0;
   string[] survivorList={"john","steve","tom","dick","harry","jacob","joe","billy","ashely","rebecca","johny","mike","nathan","jerry","william","michelle","nicole","allen","keith","anthony"};
   int[] statusList={1,1,1,1,1,1,1,1,4,3,3,3,1,1,1,1,2,3,2,2};
   Console.WriteLine("List of survivors ");
   foreach(string name in survivorList) {
    Console.WriteLine(i+1 + " " + CapFirst(name.ToString()) + GetStatus(statusList[i]));//returns: 1 plus the current counter, then the name thats been capitalized as the string, then uses the counter to pull the same index in a different array
    i++;
   }
  }
 }
}