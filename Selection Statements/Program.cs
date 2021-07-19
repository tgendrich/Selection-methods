using System;

namespace Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var r = new Random();
            var favNumber = r.Next(1, 10);
            
            bool checkComplete = false;
            Console.WriteLine("Can you guess my favorite number?");
            while (checkComplete== false)
       
            {
                
                var userInput = int.Parse(Console.ReadLine());
                if(userInput > favNumber)
                {
                    Console.WriteLine("That guess was too big, guess again");
               
                }
                else if(userInput < favNumber)
                {
                    Console.WriteLine("That guess was too small, Guess again");
                }
                else if( userInput == favNumber)
                {
                    Console.WriteLine(" You Guessed it!");
                    checkComplete = true;
                }
             
            }
            Console.WriteLine("what is your favorite school subject?");
            var pather = Console.ReadLine();
            switch(pather)
            {
                case "Gym":
                    Console.WriteLine("So you must be fit then");
                    break;
                case "Science":
                    Console.WriteLine("So you must be smart then");
                    break;
                case "Reading":
                    Console.WriteLine("So you must have a good vocabulary then");
                    break;
                case "Art":
                    Console.WriteLine("So you must be good at drawing then");
                    break;
                case "History":
                    Console.WriteLine("So you must know important dates then");
                    break;
                default:
                    Console.WriteLine("That is not a value answer");
                    break;

            }
        }   
    }
}
