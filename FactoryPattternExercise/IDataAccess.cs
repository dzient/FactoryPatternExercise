using System;
using System.Linq;
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
/// 
// IDataAccess interface, containing two methods that 
// must be implemented:
namespace FactoryExercise2
{
    public interface IDataAccess
    {
        public void SaveData();
        public List<Product> LoadData();
    }
}