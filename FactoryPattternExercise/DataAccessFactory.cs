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
    public static class DataAccessFactory 
    {
        // GetDataAccessType
        // Method takes a string representing the desired data type,
        // and returns an object of the correct data type
        // PARAMS: string (databaseType)
        // RETURNS: IDataAccess-derived object 
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "mongo": return new MongoDataAccess();
                case "sql": return new SQLDataAccess();
                case "list":
                default: return new ListDataAccess();
            }
        }
    }
}