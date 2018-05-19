using System;

namespace testproject
{
    class Program
    {

        static void Main(string[] args)
        {

            //cli is command line interface
            //dotnet new console
            /*
            going to do the rest of this in a block just because
            mkdir (folername)
            ; the semicolon ends each statement
            {} or curly Parenthesis for the block of code
            logic operators
            == && != >= (and other variations)
            */
            string myString = "A true value";
            int myInt = 9;
            if (myInt == 9)
            {
                Console.WriteLine(myString);
            }

            int number = 0;
            while (number < 3)
            {
                Console.WriteLine(number);
                number++;
            }

            Console.WriteLine("Hello World!");
        }
        public void noReturn(int one,int two){
            //does not return anything
        }
        
    }
}
