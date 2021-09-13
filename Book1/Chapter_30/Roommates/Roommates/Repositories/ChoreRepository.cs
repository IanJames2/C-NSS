using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roommates.Repositories
{
    public class ChoreRepository : BaseRepository
    {
        public ChoreRepository(string connectionString) : base(connectionString) { }

        //Create a List of Chores and call the method GetAll. Make it public
        {
            //import SqlConnection and make a variable. Set that var equal to Connection
            {
                //Open the SQLconnection

                //import SQLCommand and set the var equal to the Connection var from above. Use the built in CreateCommand method from C#.
                {
                    //Use the var that uses CreateCommand method and implement dot notation with CommandText and set this equal to an SQL Query that has the names of the columnns from the Chore Table.
                    //Create an instance of SqlDataReader and set that equal to C# built in method ExecuteReader()
                    //Create a new List of Chores.
                    //Create a while loop. While the reader Reads make values of all of the columns from the Chores table. Set a new Chore with those values, than add it to the chore table.
                }
                    //Close the reader.
                    //Return chores
            }
        }
    

            //Make an Insert Method for the Chore that does not return anything.
            {
                //import SqlConnection and set the var equal to connection
                {
                    //Open the connection.
                    //Use the CreateCommand C# built in method.
                    {
                        //Make Sql Query to insert the fields into the Chore Table.
                        //Add Each individual parameter from the Chore Table.
                        // Retrieve the id of the newly made chore using the ExecuteScalar built in method.
                        //Set the choreId equal to id.
                    }
                }
            }    
     
    }
}