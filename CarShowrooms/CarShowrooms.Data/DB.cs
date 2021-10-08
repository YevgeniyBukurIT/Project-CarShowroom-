using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CarShowrooms.Data
{
    public static class DB <T> where T : class
    {
        public static OleDbConnection connection;
        public static OleDbCommand command;
        public static OleDbDataAdapter dataAdapter;
        public static DataTable bufferTable;

        static DB()
        {
            connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["CarShowrooms.Properties.Settings.DB1ConnectionString"].ConnectionString);
            connection.Open();

            command = connection.CreateCommand();
            command.Connection = connection;

        }

        public static void Update(string condition, string values)
        {
            command.CommandText = "UPDATE " + typeof(T).Name +
                                  " SET " + values +
                                  " WHERE " + condition + ";";
            command.ExecuteNonQuery();
        }
        public static void Insert(string values)
        {
            command.CommandText = "INSERT" + " INTO " + (typeof(T).Name) +
                               " VALUES " + "(" + values + ")" + ";";
            command.ExecuteNonQuery();
        }
        
       
        public static void Delete(string query)
        {
            command.CommandText = "DELETE FROM " + typeof(T).Name +
                                  " WHERE " + query + ";";
            command.ExecuteNonQuery();
        }

    }




}

