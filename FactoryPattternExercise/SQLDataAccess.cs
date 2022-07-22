using System;
//-----------------------------------------------------------------
// FactoryPatternExercise
//
// Name: David Zientara
// Date: 7-22-2022
// Comments: An exercise in using factory patterns, part 2
// Added methods per the instructions
//-----------------------------------------------------------------

/// <summary>
/// Summary description for Class1
/// </summary>
namespace FactoryExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product {Name="XBox",Price=350},
            new Product {Name="Guitar",Price=1000},
            new Product {Name="Blender",Price=50},
            new Product {Name="Kite",Price=25}
        };
        // SaveData
        // This method doesn't do anything yet
        // PARAMS: None
        // RETURNS: Nothing
        public void SaveData()
        {

        }
        // LoadData
        // This method returns a list of products
        // PARAMS: None
        // RETURNS: List of Products (Products)
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from an SQLDataAccess database.");
            return Products;    
        }
    }
}
