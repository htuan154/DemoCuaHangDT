using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace app.Models
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider()
        {

        }
        
        private string connectionSTR = @"Data Source=DESKTOP-T8J9RG9;Initial Catalog=QL_CUAHANGDT;Integrated Security=True;Trust Server Certificate=True";



        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null, CommandType commandType = CommandType.Text)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
            }

            return data;
        }

        // Trả số dòng thành công
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure; 
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    result = command.ExecuteNonQuery();
                }
            }
            return result;
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text; 
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    result = command.ExecuteScalar();
                }
            }
            return result;
        }


        public int InsertDataUsingStoredProcedure(string procedureName, SqlParameter[] parameters)
        {
            int result = -1;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);

                        }

                        result = command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    // Handle SQL errors gracefully (e.g., logging, throwing a custom exception)
                    Console.WriteLine("Error occurred during data insertion: " + ex.Message);
                }
            }

            return result;
        }
        public int UpdateDataUsingStoredProcedure(string procedureName, SqlParameter[] parameters)
        {
            int result = -1;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        result = command.ExecuteNonQuery(); // Execute the update command
                    }
                }
                catch (SqlException ex)
                {
                    // Handle SQL errors gracefully (e.g., logging, throwing a custom exception)
                    Console.WriteLine("Error occurred during data update: " + ex.Message);
                }
            }

            return result;
        }
    }
}