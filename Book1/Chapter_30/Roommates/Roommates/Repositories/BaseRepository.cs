using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Roommates.Models;

namespace Roommates.Repositories
{
    public class BaseRepository
    {
        private string _connectionString;
    public BaseRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected SqlConnection Connection => new SqlConnection(_connectionString);
    }

}
