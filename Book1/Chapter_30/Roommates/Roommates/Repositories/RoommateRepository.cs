using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Roommates.Models;

namespace Roommates.Repositories 
{
    class RoommateRepository : BaseRepository
    {
        public RoommateRepository(string connectionString) : base(connectionString) { }

        public List<Roommate> GetById(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT FirstName, LastName, RentPortion, MoveInDate, RoomId FROM Roommate INNER JOIN Room ON Roommate.RoomId = Room.Id";

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Roommate> roommates = new List<Roommate>();

                    while(reader.Read())
                    {
                        int idCoulumnPosition = reader.GetOrdinal("Id");
                        int idValue = reader.GetInt32(idCoulumnPosition);

                        int firstNameColumnPosition = reader.GetOrdinal("FirstName");
                        string firstNameValue = reader.GetString(firstNameColumnPosition);

                        int lastNameColumnPosition = reader.GetOrdinal("LastName");
                        string lastNameValue = reader.GetString(lastNameColumnPosition);

                        int rentPortionColumnPosition = reader.GetOrdinal("RentPortion");
                        int rentPortionValue = reader.GetInt32(rentPortionColumnPosition);

                        int moveInDateColumnPosition = reader.GetOrdinal("MoveInDate");
                        DateTime moveInDateValue = reader.GetDateTime(moveInDateColumnPosition);
                        Roommate moneysaver = new Roommate
                        {
                            Id = idValue,
                            FirstName = firstNameValue,
                            LastName = lastNameValue,
                            RentPortion = rentPortionValue,
                            MoveInDate = moveInDateValue
                        };

                    roommates.Add(moneysaver);
                    };

                    reader.Close();

                    return roommates;
                }

            }
        }

    }
}
