using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roommates.Models;
using Microsoft.Data.SqlClient;


namespace Roommates.Repositories
{

    public class ChoreRepository : BaseRepository
    {
        public ChoreRepository(string connectionString) : base(connectionString) { }
        //Use a List of Chores to call the c# built in method GetAll. Make it public
        public List<ChoreRepository> GetAll()
        {
            //import SqlConnection and make a variable. Set that var equal to Connection
            using (SqlConnection conn = Connection)
            {
                //Open the SQLconnection
                conn.Open();

                //import SQLCommand and set the var equal to the Connection var from above. Use the built in CreateCommand method from C#.
                using(SqlCommand cmd = Connection.CreateCommand())
                {
                    //Use the var that uses CreateCommand method and implement dot notation with CommandText and set this equal to an SQL Query that has the names of the columnns from the Chore Table.
                    cmd.CommandText = "SELECT Id, Name FROM Chore";
                    //Create an instance of SqlDataReader and set that equal to C# built in method ExecuteReader()
                    SqlDataReader reader = cmd.ExecuteReader();
                    //Create a new List of Chores.
                    List<ChoreRepository> choreList = new List<ChoreRepository>();
                    //Create a while loop. While the reader Reads make values of all of the columns from the Chores table. Set a new Chore with those values, than add it to the chore table.
                    while(reader.Read())
                    {
                        int idColumnPosition = reader.GetOrdinal("Id");

                        int idValue = reader.GetInt32(idColumnPosition);

                        int nameColumnPosition = reader.GetOrdinal("Name");
                        string nameValue = reader.GetString(nameColumnPosition);

                        Chore chore = new Chore
                        {
                            Id = idValue,
                            Name = nameValue
                        };

                        choreList.Add(chore);
                    }
                    //Close the reader.
                    reader.Close();
                    //Return chores
                    return choreList;
                }
            }
        }


        public void Insert(Chore chore)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Room (Name) 
                                         OUTPUT INSERTED.Id 
                                         VALUES (@name)";
                    cmd.Parameters.AddWithValue("@name", chore.Name);
                    int id = (int)cmd.ExecuteScalar();

                    chore.Id = id;
                }
            }

        }

    }
}