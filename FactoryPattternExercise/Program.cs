using System;
//-----------------------------------------------------------------
// FactoryPatternExercise
//
// Name: David Zientara
// Date: 7-22-2022
// Comments: An exercise in using factory patterns, part 2
// Added methods per the instructions
//-----------------------------------------------------------------

namespace FactoryExercise2
{
    // Watched the video and followed along
    // In this class, the "client" calls the back-end,
    // and instantiates the object
    class Program
    {
        public static void Main()
        {
          
            String ? userInput = " ";
            IDataAccess myDatabase;
            bool correctInput = false;
            
            // Stay in loop until user enters valid input:
            do
            {
                correctInput = true;
                Console.Clear();
                Console.WriteLine("What kind of database do you want?");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: mongo");
                Console.WriteLine("Type: list"); 
                userInput = Console.ReadLine();
                if (userInput != "sql" && userInput != "mongo" && userInput != "list")
                    correctInput = false;
                if (!correctInput)
                {
                    Console.WriteLine("Warning: Bad input");
                    Thread.Sleep(1000);
                }
            } while (!correctInput);
            // Now that valid input has been entered, we can instantiate the object
            if (userInput != null)
            {
                myDatabase = DataAccessFactory.GetDataAccessType(userInput);
                List<Product> list = myDatabase.LoadData();
                // Iterate through the list:
                foreach (Product l in list)
                {
                    Console.WriteLine($"Product: {l.Name}, Price: {l.Price} ");
                }
            }
        }
    }
}