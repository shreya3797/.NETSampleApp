using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace WebApplication1.DataAccess
{
    class SqlDataAccess
    {
        protected void ConnectToDatabase()
        {
            string connectionString = @"Data Source=.\CarRace.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            
        }                       
    }
}